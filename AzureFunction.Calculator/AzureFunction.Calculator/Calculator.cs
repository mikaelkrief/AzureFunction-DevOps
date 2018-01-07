using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunction.Calculator
{
    public class Calculator
    {
        public static int Add (int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

    }
}
