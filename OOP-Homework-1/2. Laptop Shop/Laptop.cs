using System;

namespace _2.Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public string Model {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("The model cannot be empty.");
                this.model = value;
            }
            }
        public string Manufacturer {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != "" && value.Length <= 0) throw new ArgumentException("Manufacturer cannot be an empty sting!");
                this.manufacturer = value;
            }
            }
        public string Processor {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != "" && value.Length <= 0) throw new ArgumentException("Processor cannot be an empty sting!");
                this.processor = value;
            }
            }
        public int RAM {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0) throw new ArgumentException("The RAM cannot be negative!");
                this.ram = value;
            }
            }
        public string GraphicsCard {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != "" && value.Length <= 0) throw new ArgumentException("Graphics card cannot be an empty sting!");
                this.graphicsCard = value;
            }
            }
        public string HDD {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != "" && value.Length <= 0) throw new ArgumentException("HDD cannot be an empty sting!");
                this.hdd = value;
            }
            }
        public string Screen {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != "" && value.Length <= 0) throw new ArgumentException("Screen cannot be an empty sting!");
                this.screen = value;
            }
            }
        public Battery Battery {
            get
            {
                return this.battery;
            }
            set 
            {
                this.battery = value;
            }
        }
        public decimal Price {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Price cannot be negative!");
                this.price = Math.Round(value, 2);
            }
            }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard,
            string hdd, string screen, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = Math.Round(price, 2);
        }
        public Laptop(string model, decimal price) : this(model, "", "", 0, "", "", "", null,
            price)
        {
        }
        public override string ToString()
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            output.AppendLine("Model: " + this.Model);
            if (this.Manufacturer != "")
            {
                output.AppendLine("Manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != "")
            {
                output.AppendLine("Processor: " + this.Processor);
            }
            if (this.RAM > 0)
            {
                output.AppendLine("RAM: " + this.RAM + " GB");
            }
            if (this.GraphicsCard != "")
            {
                output.AppendLine("Graphics Card: " + this.GraphicsCard);
            }
            if (this.HDD != "")
            {
                output.AppendLine("HDD: " + this.HDD);
            }
            if (this.Screen != "")
            {
                output.AppendLine("Screen: " + this.Screen);
            }
            if (this.Battery != null)
            {
                output.Append(this.Battery.ToString());
            }
            output.AppendLine("Price: " + this.Price + " lv");
            return output.ToString();
        }
       
    }
}
