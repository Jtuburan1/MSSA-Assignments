using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    internal interface ICalculator
    {
        int Addition(int firstNum, int secondNum);
        int Subtraction(int firstNum, int secondNum);
        int Multiplication(int firstNum, int secondNum);
        int Division(int firstNum, int secondNum);
    }
}
