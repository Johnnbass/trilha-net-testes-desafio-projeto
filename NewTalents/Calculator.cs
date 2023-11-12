using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculator
    {
        private List<string> historyList;
        private string date;

        public Calculator(string date)
        {
            historyList = new List<string>();
            this.date = date;
        }

        public void historyInsert(string result)
        {
            historyList.Insert(0, $"Result: {result} - Date: {date}");
        }

        public int Sum(int val1, int val2)
        {
            var result = val1 + val2;

            historyInsert(result.ToString());

            return result;
        }

        public int Subtract(int val1, int val2)
        {
            var result = val1 - val2;

            historyInsert(result.ToString());

            return result;
        }

        public int Multiply(int val1, int val2)
        {
            var result = val1 * val2;

            historyInsert(result.ToString());

            return result;
        }

        public int Divide(int val1, int val2)
        {
            var result = val1 / val2;

            historyInsert(result.ToString());

            return result;
        }

        public double Power(double val1, double val2)
        {
            var result = Math.Pow(val1, val2);

            historyInsert(result.ToString());

            return result;
        }

        public double Square(double val)
        {
            var result = Math.Sqrt(val);

            historyInsert(result.ToString());

            return result;
        }

        public List<string> History()
        {
            historyList.RemoveRange(3, historyList.Count - 3);

            return historyList;
        }
    }
}