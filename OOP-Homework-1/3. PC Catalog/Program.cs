using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>();

            Component pc1mb =  new Component("Asus AK-47", "mini form factor", 334m);
            Component pc2mb = new Component("Gigabyte AZ32", "mini form factor", 144m);
            Component pc3mb =  new Component("My motherboard", 112m);

            Component pc1processor = new Component("i7 2345", "64 cores", 234m);
            Component pc2processor = new Component("i5 2345", "32 cores", 134m);
            Component pc3processor = new Component("i3 2200", 104m);

            Component pc1ram = new Component("32GB", "DDR5", 200m);
            Component pc2ram = new Component("16GB", "DDR5",  100m);
            Component pc3ram = new Component("8GB", 80m);

            Computer PC1 = new Computer("ASUS", pc1ram, pc1mb, pc1processor);
                
            Computer PC2 = new Computer("GigaBUUUG",pc2ram, pc2mb, pc2processor);

            Computer PC3 = new Computer("Handmade", pc3ram, pc3mb, pc3processor);

            computers.Add(PC1);
            computers.Add(PC2);
            computers.Add(PC3);

            computers = computers.OrderBy(o => o.PcPrice).ToList();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
                Console.WriteLine();
            }
        }
    }
}
