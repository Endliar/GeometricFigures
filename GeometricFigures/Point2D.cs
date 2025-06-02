using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Point2D
    {
        private double x;
        private double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX() => x;
        public double GetY() => y;

        public void AddX(double dx) => x += dx;
        public void AddY(double dy) => y += dy;
    }
}
