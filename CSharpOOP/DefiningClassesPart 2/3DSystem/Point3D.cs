using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSystem
{
    public struct Point3D
    {
        private static readonly Point3D zeroCoordinate = new Point3D(0, 0, 0);
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public Point3D(double x, double y, double z)
            : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D PointO
        {
            get { return zeroCoordinate; }
        }

        public override string ToString()
        {
            return string.Format("({0};{1};{2})", X, Y, Z);
        }
    }
}