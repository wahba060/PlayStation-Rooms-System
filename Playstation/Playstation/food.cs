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

    
    
    
    
    public partial class food : Form
    {
        private  int n, f, b;
        // public double l;
       // double w;
      
        public food()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void burgernum_ValueChanged(object sender, EventArgs e)
        {

//        b = Convert.ToInt32(burgernum.Value);

        }


        private void nachosnum_ValueChanged(object sender, EventArgs e)
        {
    //    n = Convert.ToInt32(nachosnum.Value);

        }

        private void friesnum_ValueChanged(object sender, EventArgs e)
        {
    //    f = Convert.ToInt32(friesnum.Value);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
          b = Convert.ToInt32(burgernum.Value);
            n = Convert.ToInt32(nachosnum.Value);
            f = Convert.ToInt32(friesnum.Value);
            snacks snack = new snacks(b, n, f);
           // w = snack.foodsprice();
            this.Hide();

           // timer q = new timer();
           // q.foodlabel_Click().Text = Convert.ToString(w);
            //  l = snack.foodprice();
            /* timer nb = new timer(l);


             nb.zz = l;
             nb.Show();
             this.Hide();*/
        }
        private void timer_Load(object sender, EventArgs e)
        {
            

        }
     /*  public double TotalPrice()
         {
             return x;
         }*/
       /* public double foodsprice()
        {
            return l;
        }*/
       

    }
    
}
