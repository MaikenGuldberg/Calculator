﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;
        [SetUp]
        public void SetUp()
        {
            _uut = new Calculator();
        }

        [TestCase(2, 5, 7)]
        [TestCase(2.5, 3.5, 6)]
        [TestCase(6, 10, 16)]

        public void Add_TwoNumbers_ValidResult(double a, double b, double expresult)
        {
            var result = _uut.Add(a, b);

            Assert.That(result,Is.EqualTo(expresult));
        }

        [TestCase(2, 3, -1)]
        [TestCase(5,3,2)]
        [TestCase(10,5,5)]

        public void Subtract_TwoNumbers_ValidResult(double a, double b, double expresult)
        {
            var result = _uut.Subtract(a, b);

            Assert.That(result,Is.EqualTo(expresult));
        }

        [TestCase(2, 5, 10)]
        [TestCase(2, 3, 6)]
        [TestCase(2, 5, 10)]

        public void Multiply_TwoNumbers_ValidResult(double a, double b, double expresult)
        {
            var result = _uut.Multiply(a, b);

            Assert.That(result,Is.EqualTo(expresult));
        }

        [TestCase(3, 2, 9)]
        [TestCase(2, 2, 4)]
        [TestCase(5, 3, 125)]

        public void Power_ABaseNumerAndPower_ValidResult(double x, double exp, double expresult)
        {
            var result = _uut.Power(x, exp);

            Assert.That(result,Is.EqualTo(expresult));
        }


    }
}