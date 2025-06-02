using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Square : Quadrilateral
    {
        public Square(Point2D startPoint, double side) : base(startPoint, side, side) { }
    }
}
