using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prop_finder
{
    public partial class list_new_prop_form : Form
    {
        public Lister l;
        public list_new_prop_form()
        {
            InitializeComponent();
        }

        private void list_new_prop_form_Load(object sender, EventArgs e)
        {

        }

        private void List_btn_Click(object sender, EventArgs e)
        {
            this.us_label.Text = $"{l.FirstName} {l.LastName}";
            this.email_label.Text = $"{l.User_Email}";
            //        public Property(string property_lister_email, string type, decimal startPrice, decimal endPrice, int numRooms, int numBathrooms, string city, string street, string buildingNumber, string description, decimal area, string status, string phoneNumber)
            
                Property p=new Property(l.User_Email,tybe_cmb.Text.ToString().Trim(),Convert.ToDecimal(startp_txt.Text.ToString().Trim()), Convert.ToDecimal(Endp_txt.Text.ToString().Trim()), Convert.ToInt32(bed_rooms_cmb.Text.ToString().Trim()), Convert.ToInt32(Bath_cmb.Text.ToString().Trim()),city_cmb.Text.ToString().Trim(),Street_txt.Text.ToString().Trim(),Bnum_txt.Text.ToString().Trim(),des_txt.Text.ToString().Trim(),Convert.ToDecimal(Area_cmb.Text.ToString().Trim()),status_cmb.Text.ToString().Trim(),phone_txt.Text.ToString().Trim());
            MessageBox.Show($"{p.Property_Lister_email}");
            if(l.List_property(p))
            {
                MessageBox.Show("Property Listed Succesfully");
            }
            else 
            {
                MessageBox.Show("Failed");

            }
            this.Close();
        }
    }
}
