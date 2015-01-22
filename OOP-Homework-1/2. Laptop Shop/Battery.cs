using System;
using System.Text;

namespace _2.Laptop_Shop
{
    internal class Battery
    {
        private double batteryLife;

        public Battery(string battery, double batteryLife)
        {
            this.Batt = battery;
            this.batteryLife = Math.Round(batteryLife, 2);
        }

        public Battery()
            : this("", 0)
        {
        }

        public string Batt { get; set; }

        public double BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value < 0) throw new ArgumentException("The battery life cannot be negative!");
                batteryLife = Math.Round(value, 2);
            }
        }

        public override string ToString()
        {
            var batteryOutput = new StringBuilder();
            if (Batt != "")
            {
                batteryOutput.AppendLine("Battery: " + Batt);
            }
            if (BatteryLife > 0)
            {
                batteryOutput.AppendLine("Battery Life: " + BatteryLife + " Hours");
            }
            return batteryOutput.ToString();
        }
    }
}
