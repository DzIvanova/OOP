using System;

namespace _3.PC_Catalog
{
    class Computer
    {
        private string name;
        private Component ram;
        private Component motherboard;
        private Component processor;
        //private decimal pcPrice;

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

        public Component Motherboard
        {
            get
            {
                return this.motherboard;
            }
            set
            {
                this.motherboard = value;
            }
        }

        public Component RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }
        public Component Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                this.processor = value;
            }
        }

        public decimal PcPrice
        {
            get
            {
                return this.Motherboard.Price + this.Processor.Price + this.RAM.Price;
            }
        }

        public Computer(string name, Component ram, Component motherboard, Component processor)
        {
            this.Name = name;
            this.RAM = ram;
            this.Motherboard = motherboard;
            this.Processor = processor;
        }

        public override string ToString()
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            output.AppendLine("Name: " + this.Name);
            output.AppendLine("Motherboard: " + this.Motherboard.ToString());
            output.AppendLine("Processor: " + this.Processor.ToString());
            output.AppendLine("RAM: " + this.RAM.ToString());
            output.AppendLine("Total Price: " + this.PcPrice + " lv");
            return output.ToString();
        }
    }
}
