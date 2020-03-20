using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_lvl_Adv3_dz1_Dll;

namespace WFDZ1
{ 

    public partial class DZ1 : Form
         
    {
        public DZ1()
        {
            InitializeComponent();
        }
        static Double a, b, c;

        private void button5_Click(object sender, EventArgs e)
        {
            CustomMath.SetValue();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomMath.SetValue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomMath.DiscrimSqrt(discrim);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CustomMath.Discrim(a,b,c);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomMath.SetValue();
        }
    }
}
