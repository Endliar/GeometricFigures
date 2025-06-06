﻿using System;
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

        public static Triangle FromInput(string p1Input, string p2Input, string p3Input)
        {
            Point2D ParsePoint(string input)
            {
                var parts = input.Split(',');
                if (parts.Length != 2) throw new ArgumentException("Некорректный формат точки");
                return new Point2D(int.Parse(parts[0]), int.Parse(parts[1]));
            }
            return new Triangle(
                Point2D.Parse(p1Input),
                Point2D.Parse(p2Input),
                Point2D.Parse(p3Input)
            );
        }
    }
}
