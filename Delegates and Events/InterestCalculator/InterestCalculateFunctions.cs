using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public class InterestCalculateFunctions
    {
        private double sum;
        private double interest;
        private uint year;

        public double Sum
        {
            get { return this.sum; }
            set
            {
                if(value < 0) throw new ArgumentException("The sum cannot be negative number!");
                this.sum = value;
            }
        }

        public double Interest
        {
            get { return this.interest; }
            set
            {
                if(value < 0) throw new ArgumentException("The interest cannot be negative number!");
                this.interest = value;
            }
        }

        public uint Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public InterestCalculateFunctions(double sum, double interest, uint year)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Year = year;
        }
        public decimal GetSimpleInterest(double sum, double interest, uint years)
        {
            decimal result = (decimal)(sum * (1 + (interest / 100) * years));
            return result;
        }

        public decimal GetCompoundInterest(double sum, double interest, uint years)
        {
            decimal result = (decimal)(sum * (Math.Pow(1 + (interest / 12 / 100), years * 12)));
            return result;
        }
    }
}
