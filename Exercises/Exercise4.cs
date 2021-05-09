using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    class Exercise4 : IExercise
    {
        //Question
        // Write a program in C# Sharp to display the number and frequency of number from giving array
        public void Run()
        {
            var numbers = DataUtils.GetNaturalNumbersWithHighRepetitions(20);

            var groups = from number in numbers
                         orderby number
                         group number by number;

            foreach(var group in groups)
            {
                Console.WriteLine($"Number {group.Key} appears {group.Count()} times");
            }
        }
    }
}
