using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Quadrilateral
    {
        private Point2D startPoint;
        private double width;
        private double height;

        public Quadrilateral(Point2D startPoint, double width, double height)
        {
            this.startPoint = startPoint;
            this.width = width;
            this.height = height;
        }

        public void Move(double dx, double dy)
        {
            startPoint.AddX(dx);
            startPoint.AddY(dy);
        }

        public Point2D[] GetPoints()
        {
            return new[]
            {
                startPoint,
                new Point2D(startPoint.GetX() + width, startPoint.GetY()),
                new Point2D(startPoint.GetX() + width, startPoint.GetY() + height),
                new Point2D(startPoint.GetX(), startPoint.GetY() + height)
            };
        }

        public static Quadrilateral FromInput(string startInput, string width, string height)
        {
            var startParts = startInput.Split(',');
            return new Quadrilateral(
                Point2D.Parse(startInput),
                double.Parse(width),
                double.Parse(height)
            );
        }
    }
}
