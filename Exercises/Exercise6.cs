using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    public class Exercise6 : IExercise
    {
        //Question
        // Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array.
        public void Run()
        {
            var numbers = DataUtils.GetNaturalNumbersWithHighRepetitions(25);

            var numberFrequency = from number in numbers
                                  group number by number;

            foreach(var group in numberFrequency)
            {
                Console.WriteLine($"{group.Key} {group.Key * group.Count()} {group.Count()}");
            }
        }
    }
}
