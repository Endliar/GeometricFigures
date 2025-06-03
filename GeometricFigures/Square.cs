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

        public static new Square FromInput(string startInput, string side) 
        {
            var startParts = startInput.Split(',');
            if (startParts.Length != 2)
                throw new ArgumentException("Некорректный формат начальной точки");

            return new Square(
                new Point2D(double.Parse(startParts[0]), double.Parse(startParts[1])),
                double.Parse(side));
        }
    }
}
