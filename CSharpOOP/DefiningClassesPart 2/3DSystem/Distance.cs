using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSystem
{
   static class Distance
    {
       public static double GetDistance(Point3D point1, Point3D point2)
       {
           return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X)
                + (point1.Y - point2.Y) * (point1.Y - point2.Y)
                + (point1.Z - point2.Z) * (point1.Z - point2.Z));
       }
    }
}
