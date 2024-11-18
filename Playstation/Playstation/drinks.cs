using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playstation
{
    public partial class drinks : Form
    {
        int w, c, h, f, t, s;
        public drinks()
        {
            InitializeComponent();
        }

       

        private void waternum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sodanum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void teanum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void coffeenum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frappelattenum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hotchocolatenum_ValueChanged(object sender, EventArgs e)
        {

        }

       private void btn_add_Click(object sender, EventArgs e)
        {
            w = Convert.ToInt32(waternum.Value);
            t = Convert.ToInt32(teanum.Value);
            c = Convert.ToInt32(coffeenum.Value);
            h = Convert.ToInt32(hotchocolatenum.Value);
            f = Convert.ToInt32(frappelattenum.Value);
            s = Convert.ToInt32(sodanum.Value);
            drink d = new drink(w, t, s, h, c, f);
            this.Hide();
            //x = d.drinkprice();
            
                
          //  totalprice a = new totalprice();
        }
    }
}
