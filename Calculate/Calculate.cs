using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculate
    {
        public static ICalculate Operator(Calculation sum)
        {
            switch(sum.Symbol)
            {
                case '+': return new Addition();
                case '-': return new Subtraction();
                case '*': return new Multiplication();
                case '/': return new Division();
                default : return new Addition();
            }
        }
    }
}
