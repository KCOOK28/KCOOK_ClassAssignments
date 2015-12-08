using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_Ch9_3
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            Array myInvoice = new Array();
            Array[] getArr = myInvoice.GetInvoices();

            var sortDesc = from inv in getArr
                           orderby
                               inv.desc
                           select inv;

            Console.WriteLine("Sort by Description: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Number\t\tDetail\tQuantity\tPrice");
            Console.WriteLine("--------------------------------");
            foreach(var myInv in sortDesc)
                Console.WriteLine("{0,2}\t{1,15}\t{2,10} \t{3}", myInv.number ,
                    myInv.desc,myInv.qty,myInv.rate);
            Console.WriteLine("--------------------------------");
            
            var sortPrice = from inv in getArr
                            orderby inv.rate 
                            select inv;
            Console.WriteLine("Sort by Price:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Number\t\tDetail\tQuanity\tPrice");
            Console.WriteLine("--------------------------------");

            foreach(var myInv in sortPrice)
                Console.WriteLine("{0,2}\t{1,15}\t{2,10} \t{3}", myInv.number ,
                    myInv.desc,myInv.qty,myInv.rate);
            Console.WriteLine("--------------------------------");
            
            var sortQty = from inv
                          in getArr
                          orderby
                             inv.desc
                             select new{inv.desc, inv.qty};

            Console.WriteLine("Sort by Descriptiob:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Detail\t Quantity");
                Console.WriteLine("--------------------------------");

            foreach (var myInv in sortQty)
                Console.WriteLine("{0, 15}\t{1}", myInv.desc, myInv.qty);
             Console.WriteLine("--------------------------------");
              
             var sortTotal = from inv
                             in getArr
                             let  invoiceTotal = inv.qty*inv.rate 
                             orderby
                                invoiceTotal select inv;

            Console.WriteLine("Sort by Invoice toal: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Number\t\tDetail\tQuantity\tPrice");
                 Console.WriteLine("--------------------------------");

            foreach(var myInv in sortTotal)
                Console.WriteLine("{0,2}\t{1,15}\t{2,10}\t{3}", myInv.number, myInv.desc, myInv.qty, myInv.rate);
            Console.WriteLine("--------------------------------");
           
            var sortRange = from inv
                            in getArr let total = inv.qty*inv.rate 
                            where total >200 && total<500 
                            orderby
                               total ascending 
                            select inv;

            Console.WriteLine("Sort by Range: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Number\t\tDetail\tQuantity\tPrice");
            Console.WriteLine("--------------------------------");

            foreach (var myInv in sortRange)
                Console.WriteLine("{0,2}\t{1,15}\t{2,10}\t{3}", myInv.number, myInv.desc, myInv.qty, myInv.rate);
            Console.WriteLine("--------------------------------");
            
            Console.ReadKey();        
        }

        }
}

