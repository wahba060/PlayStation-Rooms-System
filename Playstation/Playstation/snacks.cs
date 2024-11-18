using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstation
{
   /*interface snack
        {
        double foodprice(); 
        }*/
    
    class snacks  
    {
        public static int burger = 50;
        public static int fries = 15;
        public static int nachos = 30;
        private static int numofburger;
        private static int numofnachos;
        private static int numoffries;
        public static double x;
        public snacks(int Burger,int Nachos,int Fries)
        {
            numofburger = Burger;
            numoffries = Fries;
            numofnachos = Nachos;
        }
        public snacks()
        {
            
        }
        public static double foodsprice()
        {
            int totalprice;
            totalprice = (numofnachos * nachos) + (numoffries * fries) + (numofburger * burger);
            x = totalprice;
            return totalprice;

        }
       /* public double  foodssprice()
        {
            return x;
        }*/
    }
}
