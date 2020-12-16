using System;
using System.Collections.Generic;
using System.Text;

namespace _3DModel
{
    struct Point3D
    {
        public double x;
        public double y;
        public double z;
        public Point3D(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

    }
}
