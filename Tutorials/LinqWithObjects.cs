using LinqAndLambdas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    class LinqWithObjects
    {

        public static void FilterObjectByProperty()
        {
            List<Person> people = new List<Person>
            {
                new Person("Subash", 26),
                new Person("Pradip", 25),
                new Person("Pradip", 27),
                new Person("Rimal", 27),
                new Person("Psychonated", 24),
                new Person("Nirajan", 32),
                new Person("Khaled", 46)
            };

            var ageLessThan30 = from person in people
                                where person.Age < 30
                                orderby person.Name, person.Age descending //Multiple Ordering
                                select person;

            //Printing the Results
            foreach(var p in ageLessThan30)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            
        }


        public static void GroupByObjectProperty()
        {
            List<Person> people = new List<Person>
            {
                new Person("Subash", 26),
                new Person("Pradip", 25),
                new Person("Pradip", 27),
                new Person("Rimal", 27),
                new Person("Psychonated", 24),
                new Person("Nirajan", 32)
            };

            var ageGrouping = from person in people
                              group person by person.Age;

            foreach(var key in ageGrouping)
            {
                Console.WriteLine("Key: " + key.Key);
                foreach(var item in key)
                {
                    Console.WriteLine("\t " + item.Name);
                }
            }
        }
    }
}
