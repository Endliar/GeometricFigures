using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Triangle
    {
        private Point2D p1, p2, p3;

        public Triangle(Point2D p1, Point2D p2, Point2D p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public void Move(double dx, double dy)
        {
            p1.AddX(dx); p1.AddY(dy);
            p2.AddX(dx); p2.AddY(dy);
            p3.AddX(dx); p3.AddY(dy);
        }

        public IEnumerable<Point2D> GetPoints() => new[] { p1, p2, p3 };
    }
}
