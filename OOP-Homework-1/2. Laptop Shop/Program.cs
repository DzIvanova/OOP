using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptop_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter model of laptop:");
            string model = Console.ReadLine();
            Console.WriteLine("Please enter manufacturer:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Please enter type of the processor:");
            string processor = Console.ReadLine();
            Console.WriteLine("Please enter size of RAM:");
            string readRam = Console.ReadLine();
            Console.WriteLine("Please enter graphics card info:");
            string graphicsCard = Console.ReadLine();
            Console.WriteLine("Please enter HDD size:");
            string hdd = Console.ReadLine();
            Console.WriteLine("Please enter screen info:");
            string screen = Console.ReadLine();
            Console.WriteLine("Please enter battery info:");
            string battery = Console.ReadLine();
            Console.WriteLine("Please enter battery life:");
            string readBatteryLife = Console.ReadLine();
            Console.WriteLine("Please enter price of the laptop:");
            string readPrice = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(new string('-', 40));

            int ram;
            if (readRam == "") 
            {
                ram = 0;
            }
            else if (!int.TryParse(readRam, out ram))
            {
                throw new ArgumentException("Cannot convert RAM data into int!");
            }
            else
            {
                ram = int.Parse(readRam);
            }

            decimal price;
            if (readPrice == "")
            {
                price = 0;
            }
            else if (!decimal.TryParse(readPrice, out price))
            {
                throw new ArgumentException("Cannot convert price into number!");
            }
            else
            {
                price = decimal.Parse(readPrice);
            }

            double batteryLife;
            if (readBatteryLife == "")
            {
                batteryLife = 0;
            }
            else if (!double.TryParse(readBatteryLife, out batteryLife))
            {
                throw new ArgumentException("Cannot convert RAM data into int!");
            }
            else
            {
                batteryLife = double.Parse(readBatteryLife);
            }

            Battery batt = new Battery(battery, batteryLife);
            //Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.2f);
            //Battery nicd = new Battery("Ni-Cd", (float)4.5);
            Laptop lpt_first = new Laptop(model, manufacturer, processor, ram, graphicsCard, hdd, screen, batt, price);
            //Laptop lpt_second = new Laptop("Aspire E3-111-C5GL", (decimal)259.49);
            //Laptop lpt_third = new Laptop("Acer some model", (decimal)1567.43, battery: nicd, processor: "3.2 GHz", ram: "16 GB");
            Console.WriteLine(lpt_first.ToString());
        }
    }
}
