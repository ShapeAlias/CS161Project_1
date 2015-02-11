using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// Form for handling dot input  
//super simple, opens in center screen and askes for an input, doesn't allow non numbers or neg numbers or nums larger then an int
// hold them as a int for main form to grab later

namespace Project_1
{
    public partial class DotInput : Form
    {

       public int dots = 0;
       
        public DotInput()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            this.Hide();

            Owner.Refresh();
        }

        private void txtbxDots_TextChanged(object sender, EventArgs e)
        {

            if(!int.TryParse(txtbxDots.Text, out dots))
            {
                    txtbxDots.Text = "";
            }
        }  
    }
}
