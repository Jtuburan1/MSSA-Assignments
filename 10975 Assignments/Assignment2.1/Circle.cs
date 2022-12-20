using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    internal class Circle : Shape
    {
        const double pi = 3.14159265359;
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public override double CalculateArea()
        {
            return pi * _radius * _radius;
        }
    }
}
