using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = new Path();
            path.Points.Add(new Point3D(1, 2, 3));
            PathStorage.Save(path);

            Console.WriteLine(PathStorage.Load().Points[0].ToString());
        }
    }
}
