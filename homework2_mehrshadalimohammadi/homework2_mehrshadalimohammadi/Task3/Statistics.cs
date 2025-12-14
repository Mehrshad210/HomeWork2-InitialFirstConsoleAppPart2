using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_mehrshadalimohammadi.Task3
{
    public class Statistics
    {
        public void AnalyzeNumbers(int num1, ref int num2, out int num3)
        {
            num3 = num1 + num2;
            num2 = num2 * num2;
            Console.WriteLine(num1);
        }
    }
}
