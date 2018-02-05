using System;
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

            Assert.That(result, Is.EqualTo(expresult));
        }

        [TestCase(2, 3, -1)]
        [TestCase(5, 3, 2)]
        [TestCase(10, 5, 5)]

        public void Subtract_TwoNumbers_ValidResult(double a, double b, double expresult)
        {
            var result = _uut.Subtract(a, b);

            Assert.That(result, Is.EqualTo(expresult));
        }

        [TestCase(2, 5, 10)]
        [TestCase(2, 3, 6)]
        [TestCase(2, 5, 10)]

        public void Multiply_TwoNumbers_ValidResult(double a, double b, double expresult)
        {
            var result = _uut.Multiply(a, b);

            Assert.That(result, Is.EqualTo(expresult));
        }

        [TestCase(3, 2, 9)]
        [TestCase(2, 2, 4)]
        [TestCase(5, 3, 125)]

        public void Power_ABaseNumerAndPower_ValidResult(double x, double exp, double expresult)
        {
            var result = _uut.Power(x, exp);

            Assert.That(result, Is.EqualTo(expresult));
        }

        [Test]
        public void CheckAccumulator_AddFunction()
        {
            var result = _uut.Add(5, 5);

            result = 5 + _uut.Accumulator;

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]

        public void CheckAccumulator_SubtractFunction()
        {
            var result = _uut.Subtract(5, 2);

            result = 5 + _uut.Accumulator;

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]

        public void CheckAccumulator_MultiplyFunction()
        {
            var result = _uut.Multiply(5, 2);

            result = 5 + _uut.Accumulator;

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]

        public void CheckAccumulator_PowerFunction()
        {
            var result = _uut.Power(5, 2);

            result = 5 + _uut.Accumulator;

            Assert.That(result, Is.EqualTo(30));

        }

        [TestCase(4, 2, 2)]
        [TestCase(6,3,2)]
        [TestCase(5,2,2.5)]

        public void Divide_ADividendAndADivisor_ValidResult(double dividend, double divisor, double expresult)
        {
            var result = _uut.Divide(dividend, divisor);

            Assert.That(result,Is.EqualTo(expresult));
        }

        [Test]

        public void Divide_NumberDividedeByZero_ThrowsException()
        {
            Assert.Throws<System.DivideByZeroException>(() => _uut.Divide(5, 0));
        }

        [Test]
        public void Add_OverloadMethod_Valid()
        {
            var result = _uut.Add(5, 5);

            result = _uut.Add(result);

            Assert.That(result,Is.EqualTo(20));
        }

        [Test]
        public void Subtract_overloadMethod_Valid()
        {
            var result = _uut.Subtract(5, 2);

            result = _uut.Subtract(result);

            Assert.That(result,Is.EqualTo(0));
        }

        [Test]
        public void Multiply_OverloadMethod_Valid()
        {
            var result = _uut.Multiply(5, 2);

            result = _uut.Multiply(result);

            Assert.That(result,Is.EqualTo(100));
        }

        [Test]
        public void Divide_OverloadMethod_Valid()
        {
            var result = _uut.Divide(5,2);

            result = _uut.Divide(result);

            Assert.That(result,Is.EqualTo(1));
        }

        [Test]
        public void Divide_OverloadMethod_ExceptionIsThrown()
        {
            //Hvordan testes?
        }

        [Test]
        public void Power_OverloadMethod_Valid()
        {
            var result = _uut.Power(2,3);

            result = _uut.Power(result);

            Assert.That(result, Is.EqualTo(16777216));
        }


        //Ved ikke helt om denne test er god nok. Måske skal man lave en constructor hvor man kan sætte Accumulatoren til en bestemt værdi.
        [Test]

        public void Clear_AccumulatorIs5_AccumulatorIs0()
        {
            _uut.Add(2, 3);
            _uut.Clear();
            Assert.That(_uut.Accumulator,Is.EqualTo(0));

        }
    }
}
