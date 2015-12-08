using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_Ch9_3
{
    class Array
    {
        public int number;
        public string desc;
        public int qty;
        public double rate;

        public Array()
        {
 
        }

        public Array(int num, string description, int quantity, double price)
        {
            number = num;
            desc = description;
            qty = quantity;
            rate = price;
        }

        public Array[] GetInvoices()

        {
            Array one = new Array(83, "Electric sender", 7, 57.98);
            Array two = new Array(24, "Power saw", 18, 99.99);
            Array three = new Array(7,"Sledge hammer", 11, 21.50);
            Array four = new Array(77, "Hammer", 76, 11.99);
            Array five = new Array(39, "Lawn mower" ,3, 79.50);
            Array six = new Array(68 ,"Screwdriver", 106, 6.99);
            Array sev = new Array(56, "Jig saw" ,21, 11.00);
            Array eight = new Array(3, "Wrench" ,34 ,7.50);
            Array[] invArr = { one, two, three, four, five, six, sev, eight };
            return invArr;
        }






    }
}
