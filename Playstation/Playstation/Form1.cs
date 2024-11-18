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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_PS4_Click(object sender, EventArgs e)
        {
            Mode s = new Mode();
            s.Show();
            this.Hide();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_PS5_Click(object sender, EventArgs e)
        {
            modee g = new modee();
             g.Show();
            this.Hide();
            
        }
    }
}
