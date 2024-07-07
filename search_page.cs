using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace prop_finder
{
    public partial class search_page : Form
    {
        public OracleConnection conn;
        public Rentee rentee=null;
        public Image rentee_image;
        Property p;
        public search_page()
        {
               
            InitializeComponent();
           
        }
        private void search_page_Load(object sender, EventArgs e)
        {
            city_rdb.Checked = true;
            us_label.Text = $"{rentee.FirstName} {rentee.LastName}";
            email_label.Text = $"{rentee.User_Email}";
            user_picture_bx.Image = rentee_image;
            List<Property> p = rentee.search("Suhaj");
            //this.label1.Text = p.Count.ToString();

            populate_proprites(p);

            //GraphicsPath obj = new GraphicsPath();
            //obj.AddEllipse(0, 0, user_picture_bx.Width,user_picture_bx.Height);
            //Region rg = new Region(obj);
            //user_picture_bx.Region = rg;


        }


        private void city_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Property>p=rentee.search(city_cmb.Text.ToString().Trim());
            MessageBox.Show($"{p.Count}");
            populate_proprites(p);
            //dataGridView1.DataSource = p;
        }

        private void Area_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Property> p = rentee.search_DB(Convert.ToDecimal(Area_cmb.Text.ToString().Trim()));
            MessageBox.Show($"{Convert.ToDecimal(Area_cmb.Text.ToString().Trim())}\n{p.Count}");

            populate_proprites(p);

            //dataGridView1.DataSource = p;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void populate_proprites(List<Property>properties)
        {
            flowLayoutPanel1.Controls.Clear();
            property_us[] proprites_us_list = new property_us[properties.Count];
            for (int i = 0; i < properties.Count; i++)
            {
                proprites_us_list[i] = new property_us();
                proprites_us_list[i].Property = properties[i];
                proprites_us_list[i].prop_title();
                //image
                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel1.Controls.Add(proprites_us_list[i]);
                proprites_us_list[i].Click += new EventHandler(this.prop_us_click);


            }
        }

        private void city_rdb_CheckedChanged(object sender, EventArgs e)
        {
            if(city_rdb.Checked==true)
            {
                city_rdb_lbl.ForeColor = Color.Black;
                area_rdb_lbl.ForeColor = Color.Gray;
                city_cmb.Enabled = true;
                Area_cmb.Enabled = false;
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (area_rdb.Checked == true)
            {
                area_rdb_lbl.ForeColor = Color.Black;
                city_rdb_lbl.ForeColor = Color.Gray;
                city_cmb.Enabled = false;
                Area_cmb.Enabled = true;

            }
        }
        private void prop_us_click(object sender,EventArgs e)
        {
            property_us obj = (property_us)sender;
            p = obj.Property;
            prop_title_lbl.Text = $"{obj.Property.Type}, in {obj.Property.City} city, {obj.Property.Street} strret";
            prop_type_label2.Text = obj.Property.Type;
            bath_rooms_label.Text = obj.Property.NumBathrooms.ToString();
            bed_rooms_label.Text = obj.Property.NumRooms.ToString();
            area_label.Text = obj.Property.Area.ToString()+" m";
            start_price_label.Text = obj.Property.StartPrice.ToString();
            end_price_label.Text = obj.Property.EndPrice.ToString();
            Hidden_panel.SendToBack();
            prop_details_panel.BringToFront();

            // bath_rooms_label.Text=obj.pr


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apply_for_rent_form ap = new Apply_for_rent_form();
            ap.R =this.rentee;
            ap.P = this.p;
            ap.Show();
        }
        bool com_flag = true;
        private void GO_TO_comments_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(com_flag==true)
            {
                prop_details_panel.SendToBack();
                List<Rate> r = rentee.get_Rates(p.PropertyId);
                comments_section1.R = rentee;
                comments_section1.p = p;
                comments_section1.populate_Rates(r);
                comments_section1.BringToFront();
                com_flag = false;

            }
            else
            {
                comments_section1.SendToBack();
                prop_details_panel.BringToFront();

                com_flag = true;
            }
        }
    }
}
