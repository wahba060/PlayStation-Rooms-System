using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstation
{
    class ps4 : Playstation
    {
        public int Price = 50;
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

