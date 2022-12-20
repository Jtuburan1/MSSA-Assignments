using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    internal class Square : Shape
    {
        private double _sideofsquare;

        public double Sideofsquare { get => _sideofsquare; set => _sideofsquare = value; }

        public override double CalculateArea()
        {
            return _sideofsquare * _sideofsquare;
        }
    }
}
