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
   
    public partial class modee : Form
    {
        public int y;
        public modee()
        {
            InitializeComponent();
        }

        private void modee_Load(object sender, EventArgs e)
        {

        }

        private void btn_single5_Click(object sender, EventArgs e)
        {
            ps5 j = new ps5();
            y = j.modesingle();
            timer g = new timer(y);
            g.Show();
            this.Hide();
        }

        private void btn_multiplayer5_Click(object sender, EventArgs e)
        {

            ps5 j = new ps5();
            y = j.modemulti();
            timer g = new timer(y);
            g.Show();
            this.Hide();
        }
    }
}
