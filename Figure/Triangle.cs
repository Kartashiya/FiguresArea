using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны должны быть больше 0!");

            if (a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("Неверные стороны треугольника");

            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            //площадь по трём сторонам по формуле Герона
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        //проверка прямоугольности треугольника
        public bool RightTriangle()
        {
            if ((Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2)) ||
                (Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2)) ||
                (Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2)))
                return true;
            else return false;
        }
    }
}
