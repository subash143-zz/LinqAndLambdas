using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    class Exercise7 : IExercise
    {
        public void Run()
        {
            var cities = new string[] 
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"
            };

            var startFromEndFrom = from city in cities
                                   where city.StartsWith("A")
                                   where city.EndsWith("M")
                                   select city;
            Console.WriteLine(string.Join(", ", startFromEndFrom));
        }
    }
}
