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
    public partial class property_us : UserControl
    {
        public property_us()
        {
            InitializeComponent();
        }
        #region Proprites
        Property p;
        private int _pid;
        private int _pindex;
        private string _ptype;
        private string _city;
        private string _street;
        
        private string _desc;
        private Image _image;
        public Property Property
        {
            get { return p; }
            set { p = value; }
        }
        //public int Prop_ID
        //{
        //    get { return _pid; }
        //    set { _pid = value; }

        //}
        //public int Prop_Index
        //{
        //    get { return _pindex; }
        //    set { _pindex = value; }

        //}
        //[Category("Custom Props")]
        //public String Prop_type 
        //{
        //    get { return _ptype; }
        //    set { _ptype = value; }

        //}
        //[Category("Custom Props")]

        //public String city_name
        //{
        //    get { return _city; }
        //    set { _city = value;}
        //}
        //public String street_name
        //{
        //    get { return _street; }
        //    set { _street = value;  }
        //}
        public void prop_title()
        {
            this.prop_title_label.Text = $"{p.Type}, in {p.City} city , {p.Street} street";
            this.Desc_lbl.Text = $"{p.Description}";
        }




        //[Category("Custom Props")]
        //public String Description
        //{
        //    get { return _desc; }
        //    set { _desc = value; this.Desc_lbl.Text = value; }
        //}
        //[Category("Custom Props")]

        //public Image prop_image
        //{
        //    get { return _image; }
        //    set { _image = value; this.pictureBox1.Image = value; }
        //}
        #endregion
        private void property_us_Load(object sender, EventArgs e)
        {

        }

        private void Desc_lbl_Click(object sender, EventArgs e)
        {

        }

        private void prop_title_label_Click(object sender, EventArgs e)
        {

        }
    }
}
