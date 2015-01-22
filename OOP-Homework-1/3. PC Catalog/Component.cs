using System;

namespace _3.PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("The name of the PC cannot be empty or null!");
                this.name = value;
            }
        }
        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("The price cannot be negative or 0!");
                this.price = value;
            }
        }

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
        public Component(string name, decimal price)
            : this(name, null, price)
        {
        }

        public override string ToString()
        {
            System.Text.StringBuilder component = new System.Text.StringBuilder();
            component.AppendLine();
            component.AppendLine("Name: " + this.Name);
            if (this.Details != null)
            {
                component.AppendLine("Details: " + this.Details);
            }
            component.AppendLine("Price: " + this.Price + " lv");
            return component.ToString();
        }

    }
}
