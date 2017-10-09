using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division : ICalculate
    {
        public int CalculateResult(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
