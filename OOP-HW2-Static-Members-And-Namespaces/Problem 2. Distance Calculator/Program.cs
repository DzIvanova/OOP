using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_1.Point3D;

namespace Problem_2.Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X1 value:");
            string readX1 = Console.ReadLine();
            Console.WriteLine("Enter Y1 value:");
            string readY1 = Console.ReadLine();
            Console.WriteLine("Enter Z1 value:");
            string readZ1 = Console.ReadLine();

            Console.WriteLine("Enter X2 value:");
            string readX2 = Console.ReadLine();
            Console.WriteLine("Enter Y2 value:");
            string readY2 = Console.ReadLine();
            Console.WriteLine("Enter Z2 value:");
            string readZ2 = Console.ReadLine();

            double x1 = Test1.convertToDouble(readX1);
            double y1 = Test1.convertToDouble(readY1);
            double z1 = Test1.convertToDouble(readZ1);

            double x2 = Test1.convertToDouble(readX2);
            double y2 = Test1.convertToDouble(readY2);
            double z2 = Test1.convertToDouble(readZ2);

            Point3D p1 = new Point3D(x1, y1, z1);
            Point3D p2 = new Point3D(x2, y2, z2);

        }
    }
}
