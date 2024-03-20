using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3.Task2
{
    public class Figure
    {
        private Point[] _points;

        public Figure(Point point1, Point point2, Point point3)
        {
            _points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < _points.Length; i++)
            {
                int nextIndex = (i + 1) % _points.Length;
                perimeter += LengthSide(_points[i], _points[nextIndex]);
            }
            Console.WriteLine($"Perimeter of the figure: {perimeter}");
        }
    }
}
