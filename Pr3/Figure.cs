using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Figure
    {
        private Point[] points;

        public Figure(Point A, Point B, Point C)
        {
            points = new Point[3] { A, B, C };
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            points = new Point[4] { A, B, C, D };
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points = new Point[5] { A, B, C, D, E };
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            int lastPointIndex = points.Length - 1;
            for (int i = 0; i < lastPointIndex; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[lastPointIndex], points[0]);

            return perimeter;
        }

        public void FigureInfo()
        {
            int nOfPoints = points.Length;
            if (nOfPoints == 3)
            {
                Console.WriteLine("Наша фiгура - трикутник");
            } else if (nOfPoints == 4)
            {
                Console.WriteLine("Наша фiгура - чотирикутник");
            } else
            {
                Console.WriteLine("Наша фiгура - п'ятикутник");
            }
            Console.WriteLine($"Периметр фiгури: {PerimeterCalculator()}");
        }
    }
}
