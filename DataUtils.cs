using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    public class DataUtils
    {
        public static int[] GetNaturalNumbers(int count)
        {
            var retVal = new List<int>();
            for (int i = 1; i <= count; i++){
                retVal.Add(i);
            }
            return retVal.ToArray();

        }

        public static int[] GetNaturalNumbersWithHighRepetitions(int count)
        {
            var retVal = new List<int>();
            Random _rand = new Random();
            for (int i = 1; i <= count; i++)
            {
                retVal.Add(_rand.Next(-count/5, count/5));
            }
            return retVal.ToArray();

        }
        public static int[] GetPositiveAndNegativeNumbers(int count)
        {
            var retVal = new List<int>();
            Random _rand = new Random();

            for(int i = 0; i< count; i++)
            {
                retVal.Add(_rand.Next(count * -1, count));
            }

            return retVal.ToArray();
        }
    
        
    }
}
