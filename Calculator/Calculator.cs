using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                Accumulator = dividend / divisor;
                return dividend / divisor;
            }
            else
            {
                throw new System.DivideByZeroException();
            }
        }

        // * Added overloads
        public double Add(double addend)
        {

            return Accumulator + addend;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator - subtractor;
        }

        public double Multiply(double multiplier)
        {
            return Accumulator * multiplier;
        }

        public double Divide(double divisor)
        {
            if(divisor!=0)
            { 
                return Accumulator / divisor;
            }
            else
            {
                throw new System.DivideByZeroException();
            }
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent);
        }

        // * End Overloads

        public void Clear()
        {
            Accumulator = 0;
        }






        
    }
}
