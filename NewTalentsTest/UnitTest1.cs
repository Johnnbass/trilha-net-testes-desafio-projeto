using System.Runtime.CompilerServices;
using System.Reflection;
using System;
using Xunit;
using NewTalents;

namespace NewTalentsTest
{
    public class UnitTest1
    {
        public Calculator InstanceOfCalculator()
        {
            string date = "12/11/2023";

            Calculator calc = new Calculator(date);

            return calc;
        }

        [Theory]
        [InlineData(119, 87, 206)]
        [InlineData(48, 15, 63)]
        [InlineData(39, 17, 56)]
        public void SumTest(int val1, int val2, int result)
        {
            Calculator calc = InstanceOfCalculator();

            int calcResult = calc.Sum(val1, val2);

            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(254, 138, 116)]
        [InlineData(99, 11, 88)]
        [InlineData(141, 37, 104)]
        public void SubtractTest(int val1, int val2, int result)
        {
            Calculator calc = InstanceOfCalculator();

            int calcResult = calc.Subtract(val1, val2);

            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(7, 9, 63)]
        [InlineData(5, 15, 75)]
        [InlineData(3, 119, 357)]
        public void MultiplyTest(int val1, int val2, int result)
        {
            Calculator calc = InstanceOfCalculator();

            int calcResult = calc.Multiply(val1, val2);

            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(120, 30, 4)]
        [InlineData(225, 25, 9)]
        [InlineData(49, 7, 7)]
        public void DivideTest(int val1, int val2, int result)
        {
            Calculator calc = InstanceOfCalculator();

            int calcResult = calc.Divide(val1, val2);

            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(5, 2, 25)]
        [InlineData(16, 3, 4096)]

        public void PowerTest(double val1, double val2, double result)
        {
            Calculator calc = InstanceOfCalculator();

            double calcResult = calc.Power(val1, val2);

            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(169, 13)]
        [InlineData(121, 11)]
        [InlineData(400, 20)]
        public void SquareTest(double val, double result)
        {
            Calculator calc = InstanceOfCalculator();

            double calcResult = calc.Square(val);

            Assert.Equal(result, calcResult);
        }

        [Fact]
        public void DivideByZeroTest()
        {
            Calculator calc = InstanceOfCalculator();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(3, 0));
        }

        [Fact]
        public void HistoryTest()
        {
            Calculator calc = InstanceOfCalculator();

            calc.Sum(11, 17);
            calc.Divide(15, 3);
            calc.Subtract(45, 21);
            calc.Multiply(14, 3);

            var list = calc.History();

            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}
