using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    public class Exercise5 : IExercise
    {
        //Question
        // Write a program in C# Sharp to display the characters and frequency of character from giving string
        public void Run()
        {
            string givenString = "Encyclopedia";

            var groups = from c in givenString
                        group c by c;

            foreach(var group in groups)
            {
                Console.WriteLine($"Character {group.Key}: {group.Count()} times");
            }
        }
    }
}
