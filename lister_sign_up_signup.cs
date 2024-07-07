using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prop_finder
{
    public partial class lister_sign_up_signup : UserControl
    {
        Prop_System ps;
        Lister_screen lister_Screen;
        public Login_form form;
        public lister_sign_up_signup()
        {
            InitializeComponent();
            ps = new Prop_System();
        }

        private void lister_sign_up_signup_Load(object sender, EventArgs e)
        {
            GraphicsPath obj = new GraphicsPath();
            obj.AddEllipse(0, 0, profile_pic.Width, profile_pic.Height);
            Region rg = new Region(obj);
            profile_pic.Region = rg;
        }

        private void lister_sign_up_Click(object sender, EventArgs e)
        {

            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                profile_pic.Image.Save(ms, profile_pic.Image.RawFormat);  // Save the image as PNG
                imageBytes = ms.ToArray();
            }
            Lister L = new Lister(this.lister_fn_txt.Text.Trim(), this.lister_ln_txt.Text.Trim(),this.lister_email_txt.Text.Trim(), this.lister_pass_txt.Text.Trim(),this.company_name_txt.Text.Trim(),this.job_title_txt.Text.Trim(),this.Lister_phone_num.Text.Trim(),imageBytes);

            bool sign_flag = ps.sign_up_lister(L);
            if (sign_flag)
            {
                MessageBox.Show("SignUP succeeded");
                lister_Screen = new Lister_screen();

                lister_Screen.lister = L;
                lister_Screen.Lister_image = profile_pic.Image;
                lister_Screen.Show();
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

        private void circularPictureBox1_Click(object sender, EventArgs e)
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
