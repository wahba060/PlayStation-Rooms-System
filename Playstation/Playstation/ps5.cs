using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstation
{
    class ps5:Playstation
    {
        public int Price = 100;
        public int modesingle()
        {
            Price = Price + 20;
            return Price;
        }

        public int modemulti()
        {
            Price = Price + 40;
            return Price;
        }

    }
}
