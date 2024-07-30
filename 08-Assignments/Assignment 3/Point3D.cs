using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Point3D : IFormattable
    {

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Point3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

         public override string ToString()
        {
            return $"Point3D(x: {x}, y: {y}, z: {z})";
        }

        
    }
}