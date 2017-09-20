using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
          double mealCost, tip, tax, totalCost;
            double taxPercentage, tipPercent;
            int roundTotal;
            mealCost = Convert.ToDouble(Console.ReadLine());
            tipPercent = Convert.ToInt32(Console.ReadLine());
            taxPercentage = Convert.ToInt32(Console.ReadLine());
            tip = (tipPercent / 100) * mealCost;
            tax = (taxPercentage / 100) * mealCost;
            totalCost = mealCost + tip + tax;
            roundTotal = Convert.ToInt32(totalCost);
            Console.WriteLine("The total meal cost is {0} dollars.", roundTotal);
            Console.ReadLine();
        }
    }
}