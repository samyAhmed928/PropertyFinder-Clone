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
    public partial class comment_us : UserControl
    {
        private string _user_email;
        private string _user_name;
        private string _comment;
        private int _rate;
        private Image _image;
        private PictureBox[] stars;

        [Category("Custom Props")]

        public String User_email
        {
            get { return _user_email; }
            set
            { 
               _user_email = value;
                email_label.Text = value;
            }
        }
        [Category("Custom Props")]

        public String User_Name
        {
            get { return _user_name; }
            set
            {
                _user_name = value;
                this.us_label.Text = value;


            }
        }
        [Category("Custom Props")]
        public String Comment
        {
            get { return _comment; }
            set
            {
                _comment = value;
                this.Comment_txt.Text = value;


            }
        }

        [Category("Custom Props")]

        public Image prop_image
        {
            get { return _image; }
            set { _image = value; this.prof_pic.Image = value; }
        }

        public int Rate
        {
            get { return _rate; }
            set
            {
                _rate = value;
                for(int i=0;i<value;i++)
                {
                    this.stars[i].Image=Properties.Resources.yellow_star;
                }


            }
        }
        public comment_us()
        {
            InitializeComponent();
            stars[0] = star1_bx;
            stars[1] = star2_bx;
            stars[2] = star3_bx;
            stars[3] = star4_bx;
            stars[4] = star5_bx;

        }

        private void comment_us_Load(object sender, EventArgs e)
        {

        }
        bool like_checked = false;
        private void Like_bx_Click(object sender, EventArgs e)
        {
            if(like_checked==false)
            {
                this.Like_bx.Image = Properties.Resources.like_checked;
                like_checked = true;
            }
            else
            {
                this.Like_bx.Image = Properties.Resources.like;

                like_checked = false;

            }
        }
        bool dislike_checked = false;

        private void disLike_bx_Click(object sender, EventArgs e)
        {
            if (dislike_checked == false)
            {
                this.disLike_bx.Image = Properties.Resources.dislike_checked;
                dislike_checked = true;
            }
            else
            {
                this.disLike_bx.Image = Properties.Resources.dislike;

                dislike_checked = false;

            }
        }
    }
}
