using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstation
{
    class Playstation
    {
        private int price;
        public int  Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }
        private string mode;
        public string Mode
        {
            get
            {
                return mode;
            }
            set
            {
                this.mode = value;
            }
        }

        private int time;
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                this.time = value;
            }

        }
    }
}
