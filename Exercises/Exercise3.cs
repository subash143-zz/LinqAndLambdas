using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    //Question
    //Write a program in C# Sharp to find the number of an array and the square of each number
    public class Exercise3 : IExercise
    {
        public void Run()
        {
            var numbers = DataUtils.GetPositiveAndNegativeNumbers(50);

            var squareNumbers = from number in numbers
                                select new
                                {
                                    Number = number,
                                    SqrNo = number*number
                                };
            
            foreach(var item in squareNumbers)
            {
                Console.WriteLine($"{{ Number = {item.Number}, SqrNo = {item.SqrNo} }}");
            }
        }
    }
}
