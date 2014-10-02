using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public class FandA
    {
        public static void Main()
        {
            InterestCalculateFunctions mySimpleInterestCalculation = new InterestCalculateFunctions(2500.0, 7.2, 15);
            Func<double, double, uint, decimal> CalculateSimpleInterest = mySimpleInterestCalculation.GetSimpleInterest;
            decimal result = CalculateSimpleInterest(mySimpleInterestCalculation.Sum, mySimpleInterestCalculation.Interest, mySimpleInterestCalculation.Year);
            Console.WriteLine("{0:F4}", result);

            InterestCalculateFunctions myCompoundInterestCalculation =
            new InterestCalculateFunctions(500, 5.6, 10);
            Func<double, double, uint, decimal> CalculateCompoundInterest = myCompoundInterestCalculation.GetCompoundInterest;
            decimal compoundResult = CalculateCompoundInterest(myCompoundInterestCalculation.Sum,
                myCompoundInterestCalculation.Interest, myCompoundInterestCalculation.Year);
            Console.WriteLine("{0:F4}", compoundResult);
        }
    }

}
