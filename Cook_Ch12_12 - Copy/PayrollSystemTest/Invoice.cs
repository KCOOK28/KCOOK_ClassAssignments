using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystemTest
{
    public class Invoice : IPayable
    {
        private int quantity;
        private decimal pricePerItem;

        public string PartNumber { get; set; }

        public string PartDescription { get; set; }

        public Invoice(string part, string description, int count,
            decimal price)
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            PricePerItem = price;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value >= 0)
                    quantity = value;
                else
                    throw new ArgumentOutOfRangeException("Quantity", 
                        value, "Quantity must be >= 0");
            }
        }
        

        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            } // end get

            set
            {
                if (value >= 0) // validate price
                   pricePerItem = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
            "{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}",
            "invoice", "part number", PartNumber, PartDescription,
             "quantity", Quantity, "price per item", PricePerItem);
        }
       
        public decimal GetPaymentAmount()
        {
            return Quantity * PricePerItem;
        }
    }
}
