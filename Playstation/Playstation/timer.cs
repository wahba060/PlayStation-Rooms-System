using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Playstation
{

   /* interface foods
    {
        double foodssprice();

    }*/



    public partial class timer : Form 
    {


        


        public Stopwatch stopWatch;
        public int y;
        private double x;
        public double total = 0;
        int timee;
        int w;
       // double w; double l;

      /*  public void drinkola()
        {
            drink d = new drink();
            w = d.foodssprice();

        }

        public void foodola()
        {
            snacks f = new snacks();
            l = f.foodssprice();
        }*/
        
        //public double zz { get; set; }
        //public double w;


    /* food u = new food(); 
       public void ay7aga()
        {
            w = u.foodsprice();
        }*/
   /*  u.foodsprice();
        public void fodz();
        {
         w= u.foodsprice();
            

        }*/
       
        public timer()
        {
            InitializeComponent();

        }
        public timer(int y)
        {
            InitializeComponent();
            this.y = y;
        }
        public timer(double x)
        {
            InitializeComponent();
            this.x= x;
        }
        private void timer_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

           textprice.Text = Convert.ToString ((y * timee) + snacks.foodsprice() + drink.drinksprice()) ;
          
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            food g = new food();
            //total = g.TotalPrice();
            g.Show();  
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            drinks g = new drinks();
            g.Show();
        }

        private void timer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textprice_Click(object sender, EventArgs e)
        {

        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //stopWatch.;
            this.textResult.Text = stopWatch.Elapsed.ToString();
            //ong h = stopWatch.Elapsed.Hours;
            long h = stopWatch.Elapsed.Seconds;
            if (h ==15) //timee=10
            {
                stopWatch.Stop();
            }
            

        }

        private void timebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            timee = Convert.ToInt32(timebox.Text);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        public void drinklabel_Click(object sender, EventArgs e)
        {

        }

        public void foodlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
