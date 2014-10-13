using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer
{
    public class Payments
    {
        private string productName;
        private decimal price;

        public Payments(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            string paymentString = string.Format("Product Name: {0}\nPrice: {1:F2}", this.ProductName, 
                this.Price);
            return paymentString;

        }
    }
}
