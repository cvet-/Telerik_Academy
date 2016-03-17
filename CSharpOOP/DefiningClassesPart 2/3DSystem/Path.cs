using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSystem
{
    // Holds a sequence of points
    public class Path
    {
        public List<Point3D> Points { get; set; }

        public Path()
        {
            Points = new List<Point3D>();
        }
    }
}
