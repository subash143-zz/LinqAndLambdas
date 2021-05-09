using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    public class Exercise2 : IExercise
    {
        //Question
        // Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
        public void Run()
        {
            var numbers = DataUtils.GetPositiveAndNegativeNumbers(100);
            var positiveNumbers = from number in numbers
                                  where number > 0
                                  where number > -1
                                  orderby number
                                  select number;

            Console.Write(string.Join(", ", positiveNumbers));
        }
    }
}
