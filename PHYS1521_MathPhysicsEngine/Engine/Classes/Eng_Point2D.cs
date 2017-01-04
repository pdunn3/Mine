using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class simulates a point in 2D space.
    /// </summary>
    public class Eng_Point2D
    {
        public double x { get; set; }
        public double y { get; set; }

        public Eng_Point2D() { }
        public Eng_Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
