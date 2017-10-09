using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public char Symbol { get; set; }
        public string SumAsString { get; set; }

        public Calculation(string sum)
        {
            SumAsString = sum.Replace(" ", "");
            SetSumComponents();
        }

        private void SetSumComponents()
        {
            char operation = ' ';
            if (SumAsString.Contains("-")) { operation = '-'; }
            if (SumAsString.Contains("+")) { operation = '+'; }
            if (SumAsString.Contains("*")) { operation = '*'; }
            if (SumAsString.Contains("/")) { operation = '/'; }

            Num1 = Convert.ToInt32(SumAsString.Split(operation)[0]);
            Num2 = Convert.ToInt32(SumAsString.Split(operation)[1]);
            Symbol = operation;
        }

        public int GetResult()
        {
            ICalculate result = Calculate.Operator(this);
            return result.CalculateResult(this.Num1,this.Num2);
        }
    }
}
