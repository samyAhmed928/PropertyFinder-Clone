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

namespace prop_finder
{
    public partial class Apply_for_rent_form : Form
    {
        
        public Rentee R;
        public Property P;
        public Apply_for_rent_form()
        {
            InitializeComponent();
        }

        private void apply_for_rent_btn_Click(object sender, EventArgs e)
        {

            if (R.applyforrent(P, this.sug_price_nud.Value, this.message_txt.Text) == false)
            {
                MessageBox.Show("You have already submitted a rent request for this property.");
                
            }
            else
            {
                MessageBox.Show("Rent request has been sended.");

            }
            this.Close();
            
            

        }

        private void Apply_for_rent_form_Load(object sender, EventArgs e)
        {
            this.sug_price_nud.Minimum = P.StartPrice;
            this.sug_price_nud.Maximum = P.EndPrice;
            this.sug_price_nud.Value = P.StartPrice;

            
        }
    }
}
