using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    internal abstract class Shape
    {
        private int _id;
        private string _name;
        private string _color;
        private int _numOne;
        private int _numTwo;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int NumOne
        {
            get { return _numOne; }
            set { _numOne = value; }
        }
        public int NumTwo
        {
            get { return _numTwo; }
            set { _numTwo = value; }
        }

        public virtual double CalculateArea()
        {
            return _numOne * _numTwo;
        }
    }
}
