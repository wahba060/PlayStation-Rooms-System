using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstation
{
    class drink
    {
        private static int tea = 10;
        private static int water = 5;
        private static int frappe_latte = 30;
        private static int coffee = 30;
        private static int soda = 15;
        private static int Hot_chocolate = 30;
        private static int numoftea;
        private static int numofwater;
        private static int numoffrappe_latte;
        private static int numofcoffee;
        private static int numofsoda;
        private static int numofhotchocolate;
        public static double x;
       public drink(int water, int tea, int soda,int hotchocolate,int coffee,int farppelatte)
        {
            numoftea = tea;
            numofwater = water;
            numoffrappe_latte = farppelatte;
            numofsoda = soda;
            numofcoffee = coffee;
            numofhotchocolate = hotchocolate;
        }
        public drink()
        {

        }
        public static double drinksprice()
        {
            int totalprice;
            totalprice = (numoftea * tea) + (numofwater * water) + (numoffrappe_latte * frappe_latte) + (numofcoffee * coffee) + (numofsoda * soda) + (numofhotchocolate * Hot_chocolate);
            x = totalprice;
            return totalprice;
        }
       /* public double foodssprice()
        {
            return x;
        }*/
}
}
