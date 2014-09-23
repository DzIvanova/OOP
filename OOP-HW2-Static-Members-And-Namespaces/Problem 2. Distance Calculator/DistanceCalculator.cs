using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_1.Point3D;

namespace Problem_2.Distance_Calculator
{
    class DistanceCalculator
    {
        public static double CalcDistance(Point3D p1, Point3D p2){
            double distance = 0;
            distance = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) +
                (p1.Y - p2.Y) * (p1.Y - p2.Y) +
                (p1.Z - p2.Z) * (p1.Z - p2.Z));
            return distance;
        }
    }
}
