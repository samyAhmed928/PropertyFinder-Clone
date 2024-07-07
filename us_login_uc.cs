using Oracle.DataAccess.Client;
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
    public partial class us_login_uc : UserControl
    {
        public OracleConnection conn;
        public Login_form form;
        search_page search_Page;
        Lister_screen ls;
        Prop_System ps;
   

       
        public us_login_uc()
        {
            InitializeComponent();
        }

        private void us_login_uc_Load(object sender, EventArgs e)
        {
            ps = new Prop_System();

        }

        private void L_rentee_btn_Click(object sender, EventArgs e)
        {
            Rentee R = ps.rentee_LogIn(Email_txb.Text.ToString().Trim(), Pass_txb.Text.ToString().Trim());

            Image profilePic = null;
            if (R.profile_image != null && R.profile_image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(R.profile_image))
                {
                    profilePic = Image.FromStream(ms);
                }
            }
            if (R != null)
            {
                MessageBox.Show("login succeeded");
                search_Page = new search_page();
                search_Page.rentee = R;
                if(profilePic != null)
                {
                    search_Page.rentee_image = profilePic;
                    MessageBox.Show("NOT NULL");
                }
                else
                {
                    MessageBox.Show("null");
                }
                search_Page.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("login failed");
            }

        }

        private void L_lister_btn_Click(object sender, EventArgs e)
        {
            Image profilePic = null;

            Lister L = ps.Lister_LogIn(Email_txb.Text.ToString().Trim(), Pass_txb.Text.ToString().Trim());
            if (L.profile_image != null && L.profile_image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(L.profile_image))
                {
                    profilePic = Image.FromStream(ms);
                }
            }
            if (L != null)
            {
                MessageBox.Show("login succ");
                MessageBox.Show($"{L.User_Email}\n{L.Password}\n{L.FirstName}\n{L.LastName}\n{L.Company_name}\n{L.Job_title}\n{L.Phone_number}\n");
                ls = new Lister_screen();
                ls.lister = L;
                if (profilePic != null)
                {
                    ls.Lister_image = profilePic;
                }
                ls.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("login failed");
            }


        }
    }
}
