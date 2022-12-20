using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2._2
{
    internal class TipCalculator
    {
        private decimal _billTotal;
        private decimal _total;
        const decimal TenPercent = .10m;
        const decimal FifteenPercent = .15m;
        const decimal TwentyPercent = .20m;

        public decimal BillTotal { get => _billTotal; set => _billTotal = value; }
        public decimal Total { get => _total; }

        public decimal CaclulateTip(decimal billTotal, int tipPercentage)
        {
            switch(tipPercentage)
            {
                case 10:
                   return _total = billTotal + (billTotal * TenPercent);
                case 15:
                    return _total = billTotal + (billTotal * FifteenPercent);
                case 20:
                    return _total = billTotal + (billTotal * TwentyPercent);
                default:
                    return 0;
            }
        }
        public void TipCaclulatorMenu()
        {
            Console.WriteLine($"Please select the percentage of the total bill you would like to tip:\n{TenPercent:P}\n{FifteenPercent:P}\n{TwentyPercent:P}");
            int choice = int.Parse(Console.ReadLine()!);
            switch(choice)
            {
                case 10:
                    Console.WriteLine("Please enter your total bill:");
                    decimal billTotalTen = Convert.ToDecimal(Console.ReadLine()!);
                    CaclulateTip(billTotalTen, choice);
                    Console.WriteLine();
                    Console.WriteLine($"Your total with the tip amount added is {_total:C2}");
                    break;
                case 15:
                    Console.WriteLine("Please enter your total bill:");
                    decimal billTotalFiftn = Convert.ToDecimal(Console.ReadLine()!);
                    CaclulateTip(billTotalFiftn, choice);
                    Console.WriteLine();
                    Console.WriteLine($"Your total with the tip amount added is {_total:C2}");
                    break;
                case 20:
                    Console.WriteLine("Please enter your total bill:");
                    decimal billTotalTwnty = Convert.ToDecimal(Console.ReadLine()!);
                    CaclulateTip(billTotalTwnty, choice);
                    Console.WriteLine();
                    Console.WriteLine($"Your total with the tip amount added is {_total:C2}");
                    break;
            }
        }
    }
}
