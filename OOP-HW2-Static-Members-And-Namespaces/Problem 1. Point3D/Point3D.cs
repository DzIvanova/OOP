﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Point3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint;

        static Point3D()
        {
            Point3D.startingPoint = new Point3D(0, 0, 0);
        }

        public static Point3D StartPoint
        {
            get
            {
                return Point3D.startingPoint;
            }
        }
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            string output = "Your points:{";
            output += string.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
            output += "}";
            return output;
        }
    }
}
