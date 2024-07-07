using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prop_finder
{
    public partial class Login_form : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Login_form()
        {

            //InitializeComponent();
            
            InitializeComponent();
            

               

        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            this.us_login_uc1.form = this;
            this.rentee_sign_up1.form = this;
            this.lister_sign_up_signup1.form = this;
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
        }

        private void sign_up_rentee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.rentee_sign_up1.BringToFront();
        }

        private void lister_sign_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lister_sign_up_signup1.BringToFront();

        }

        private void Login_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.us_login_uc1.BringToFront();

        }

        private void us_login_uc1_Load(object sender, EventArgs e)
        {

        }
    }
}
