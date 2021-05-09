using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    //Question:
    //Write a program in C# Sharp to shows how the three parts of a query operation execute.
    public class Excerise1 : IExercise
    {
        public void Run()
        {
            var numbers = DataUtils.GetNaturalNumbers(100);

            var evenNumbers = from num in numbers //Choose collection and iterator
                              where num % 2 == 0 //Create condition
                              select num; //Select 

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
