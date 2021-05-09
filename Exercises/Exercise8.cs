using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    class Exercise8 : IExercise
    {
        //Question
        //Write a program in C# Sharp to display the list of items in the array according to the length of the string then by name in ascending order.
        public void Run()
        {
            var cities = new string[]
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"
            };

            var orderedCities = from city in cities
                                orderby city.Length ascending, city
                                select city;

            Console.WriteLine(string.Join(", ", orderedCities));
        }
    }
}
