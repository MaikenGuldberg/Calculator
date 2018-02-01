﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }









        public double Divide(double dividend, double divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
