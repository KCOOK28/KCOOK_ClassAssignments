using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystemTest
{
    public class PayableInterfaceTest
    {
        public static void Main(string[] args)
        {
            IPayable[] payableObjects = new IPayable[6];

            payableObjects[0] = new Invoice("01234", "seat", 2, 375.00M );
            payableObjects[1] = new Invoice("56789", "tire", 4, 79.95M);
            payableObjects[ 2 ] = new HourlyEmployee( "John", "Smith",
                "111-11-1111", 15.75M, 40);
            payableObjects[ 3 ] = new SalariedEmployee( "Lisa", "Barnes",
                "888-88-8888", 1200.00M);
            payableObjects[4] = new CommissionEmployee("Kory", "Barnes",
                "777-77-7777", 1800.00M, .75M);
            payableObjects[5] = new BasePlusCommissionEmployee("Grant", "Brick",
                "555-55-5555", 5000.00M, .5M, 80000.00M);


            Console.Write(
                "Invoices and Employees processed polymoprhically:\n");

            foreach(var currentPayable in payableObjects)
            {
                Console.WriteLine("{0}\npayment due: {1:C}\n",
                    currentPayable, currentPayable.GetPaymentAmount());
            }
        }

    }
   }


