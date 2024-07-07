using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prop_finder
{
    public partial class Comments_section : UserControl
    {
        public Rentee R;
        public List<Rate>rates;
        public Property p;
        int rate = 0;

        public Comments_section()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comments_section_Load(object sender, EventArgs e)
        {

        }
        public void populate_Rates(List<Rate> rates)
        {
            flowLayoutPanel1.Controls.Clear();
            Rating_comment[] rates_us_list = new Rating_comment[rates.Count];
            for (int i = 0; i < rates.Count; i++)
            {
                rates_us_list[i] = new Rating_comment();
                rates_us_list[i].Rate= rates[i].Rating;
                rates_us_list[i].Comment=rates[i].comment;
                rates_us_list[i].User_email=rates[i].u_email;
                rates_us_list[i].User_Name=$"{rates[i].u_fname} {rates[i]._u_lname}";
                rates_us_list[i].profile_image=rates[i].u_pic;

                //image
                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel1.Controls.Add(rates_us_list[i]);


            }
        }
        private void star1_bx_Click(object sender, EventArgs e)
        {
            this.star1_bx.Image = Properties.Resources.yellow_star;
            this.pic_star2.Image = Properties.Resources.star;
            this.star3_bx.Image = Properties.Resources.star;
            this.star4_bx.Image = Properties.Resources.star;
            this.star5_bx.Image = Properties.Resources.star;
            rate = 1;


        }

        private void star2_bx_Click(object sender, EventArgs e)
        {
            this.star1_bx.Image = Properties.Resources.yellow_star;
            this.pic_star2.Image = Properties.Resources.yellow_star;
            this.star3_bx.Image = Properties.Resources.star;
            this.star4_bx.Image = Properties.Resources.star;
            this.star5_bx.Image = Properties.Resources.star;
            rate = 2;

        }

        private void star3_bx_Click(object sender, EventArgs e)
        {
            this.star1_bx.Image = Properties.Resources.yellow_star;
            this.pic_star2.Image = Properties.Resources.yellow_star;
            this.star3_bx.Image = Properties.Resources.yellow_star;
            this.star4_bx.Image = Properties.Resources.star;
            this.star5_bx.Image = Properties.Resources.star;
            rate = 3;
        }

        private void star4_bx_Click(object sender, EventArgs e)
        {
            this.star1_bx.Image = Properties.Resources.yellow_star;
            this.pic_star2.Image = Properties.Resources.yellow_star;
            this.star3_bx.Image = Properties.Resources.yellow_star;
            this.star4_bx.Image = Properties.Resources.yellow_star;
            this.star5_bx.Image = Properties.Resources.star;
            rate = 4;
        }

        private void star5_bx_Click(object sender, EventArgs e)
        {
            this.star1_bx.Image = Properties.Resources.yellow_star;
            this.pic_star2.Image = Properties.Resources.yellow_star;
            this.star3_bx.Image = Properties.Resources.yellow_star;
            this.star4_bx.Image = Properties.Resources.yellow_star;
            this.star5_bx.Image = Properties.Resources.yellow_star;
            rate = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R.Rate(p, richTextBox1.Text, rate);
            Rating_comment rate_panel = new Rating_comment();

            rate_panel = new Rating_comment();
            rate_panel.Rate = rate;
            rate_panel.Comment = richTextBox1.Text;
            rate_panel.User_email = R.User_Email;
            rate_panel.User_Name = $"{R.FirstName} {R.LastName}";
            Image image;

            using (MemoryStream ms = new MemoryStream(R.profile_image))
            {
                image = Image.FromStream(ms);
            }
            rate_panel.profile_image = image;
            flowLayoutPanel1.Controls.Add(rate_panel);

        }
    }
}
