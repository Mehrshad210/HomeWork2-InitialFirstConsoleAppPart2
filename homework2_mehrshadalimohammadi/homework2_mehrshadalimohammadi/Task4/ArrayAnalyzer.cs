using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_mehrshadalimohammadi.Task4
{
    public class ArrayAnalyzer
    {
        public void AnalyzeArray(int[] arr, ref int max, out double average)
        {
            if (arr.Length == 0)
            {
                max = 0;
                average = 0.0;
                return;
            }
            int sum = 0;
            max = arr[0];

            foreach (int num in arr)
            {
                sum += num;

                if (num > max)
                    max = num;
            }
            average = (double)sum / arr.Length;

        }
    }

}
