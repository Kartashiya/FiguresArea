using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circul : IFigure
    {
        public double Radius { get; }

        public Circul(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0!");
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
