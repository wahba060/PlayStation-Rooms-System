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
    public partial class Mode : Form
    {
        public int y;
       
        public Mode()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Mode_Load(object sender, EventArgs e)
        {

        }

        private void btn_single4_Click(object sender, EventArgs e)
        {
            
            ps4 j = new ps4();
            y= j.modesingle();
            timer g = new timer(y);
            g.Show();
            this.Hide();

        }

        private void btn_multiplayer4_Click(object sender, EventArgs e)
        {
            
            ps4 j = new ps4();
           y= j.modemulti();
            timer g = new timer(y);
            g.Show();
            this.Hide();

        }
       
    }
}
