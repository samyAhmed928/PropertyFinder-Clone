using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace prop_finder
{
    public partial class Lister_screen : Form
    {
        public OracleConnection conn;
        public Lister lister;
        public Image Lister_image;
        OracleDataAdapter adapter=null;
        DataSet dataSet=null;
        list_new_prop_form lnp;
       
        public Lister_screen()
        {
            InitializeComponent();
            lnp = new list_new_prop_form();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lister_screen_Load(object sender, EventArgs e)
        {
            us_label.Text = $"{lister.FirstName} {lister.LastName}";
            email_label.Text = $"{lister.User_Email}";
            pictureBox1.Image = Lister_image;
            List<Property>props= lister.search_DB_Dis(lister.User_Email, ref adapter, ref dataSet);
            this.dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lister.Update_property(ref adapter, ref dataSet);
            List<Property> props = lister.search_DB_Dis(lister.User_Email, ref adapter, ref dataSet);
            this.dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lnp.l = lister;
            lnp.Show();
           
        }
    }
}
