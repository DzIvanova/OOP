using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Point3D
{
    class Test1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X value:");
            string readX = Console.ReadLine();
            Console.WriteLine("Enter Y value:");
            string readY = Console.ReadLine();
            Console.WriteLine("Enter Z value:");
            string readZ = Console.ReadLine();

            double x = convertToDouble(readX);
            double y = convertToDouble(readY);
            double z = convertToDouble(readZ);

            //Point3D p1 = new Point3D(1.2, 3.3, 1);
            Point3D point = new Point3D(x, y, z);
            Console.WriteLine(point.ToString());

        }

        public static double convertToDouble(string readPoint)
        {
            double point;
            if (readPoint == "")
            {
                point = 0;
            }
            else if (!double.TryParse(readPoint, out point))
            {
                throw new ArgumentException("Cannot convert data into double!");
            }
            else
            {
                point = double.Parse(readPoint);
            }
            return point;
        }
    }
}
