using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hand coded test

            Calculator calc = new Calculator();

            //Add
            Console.WriteLine("Add({0}, {1}) = {2}",2,5,calc.Add(2,5));
        }
    }
}
