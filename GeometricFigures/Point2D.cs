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

        public static Point2D Parse(string input)
        {
            var parts = input.Split(',');
            if (parts.Length != 2)
                throw new FormatException("Координаты точки должны быть в формате X,Y");

            if (!double.TryParse(parts[0], out double x))
                throw new FormatException("Некорректное значение координаты X");

            if (!double.TryParse(parts[1], out double y))
                throw new FormatException("Некорректное значение координаты Y");

            return new Point2D(x, y);
        }
    }
}
