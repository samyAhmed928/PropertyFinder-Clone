using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prop_finder
{
    public partial class Rentee_sign_up : UserControl
    {
        Prop_System ps;
        search_page search_Page;
        public Login_form form;
        //string filePath;
        public Rentee_sign_up()
        {
            InitializeComponent();
            ps = new Prop_System();
        }

        private void Rentee_sign_up_Load(object sender, EventArgs e)
        {
            GraphicsPath obj = new GraphicsPath();
            obj.AddEllipse(0, 0, profile_pic.Width, profile_pic.Height);
            Region rg = new Region(obj);
            profile_pic.Region = rg;
        }

        private void ren_sign_btn_Click(object sender, EventArgs e)
        {
            //
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                profile_pic.Image.Save(ms, profile_pic.Image.RawFormat);  // Save the image as PNG
                imageBytes = ms.ToArray();
            }

            Rentee R = new Rentee(this.rn_email_txt.Text.Trim(), this.ren_pass_text.Text.Trim(), this.ren_fname_txt.Text.Trim(), this.last_ren_name_txt.Text.Trim(),imageBytes);

            bool sign_flag = ps.sign_up_rentee(R);
            if (sign_flag)
            {
                MessageBox.Show("SignUP succeeded");
                search_Page = new search_page();
                search_Page.rentee = R;
                search_Page.rentee_image = profile_pic.Image;
                search_Page.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("SignUP Failed");

            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Select an image file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Do something with the selected file path
                //filePath = openFileDialog1.FileName;
                profile_pic.Image = Image.FromFile(openFileDialog1.FileName);


            }
            else
            {

            }
        }



        private void profile_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Select an image file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Do something with the selected file path
                //filePath = openFileDialog1.FileName;
                profile_pic.Image = Image.FromFile(openFileDialog1.FileName);


            }
            else
            {

            }
        }
    }
}
