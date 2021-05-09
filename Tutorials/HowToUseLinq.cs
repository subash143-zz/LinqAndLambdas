using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    public class HowToUseLinq
    {
        public static void NumbersLessThanFiveUsingWhere()
        {
            int[] numbers = new int[] { 3, 4, 5, 12, 3, 4, 10, 6, 7, 8, 9, 19, 3, 4, 5, 30 };
            
            // 1. Using LINQ
            var numbersLessThanFive = from number in numbers
                                      where number < 5
                                      select number;
            Console.WriteLine("Result Using LINQ");
            Console.WriteLine(string.Join(", ", numbersLessThanFive));


            // 2. Using ForEach Loop
            var numbersLessThanFiveForEach = new List<int>();
            foreach(var number in numbers)
            {
                if(number < 5)
                {
                    numbersLessThanFiveForEach.Add(number);
                }
            }
            Console.WriteLine("Result Using ForEach");
            Console.WriteLine(string.Join(", ", numbersLessThanFiveForEach));


            // 3. Using Function Style LINQ
            var numbersLessThanFiveFunctionStyle = numbers.Where(x => x < 5);
            Console.WriteLine("Result Using Function Style LINQ");
            Console.WriteLine(string.Join(", ", numbersLessThanFiveFunctionStyle));

        }


        public static void MultipleWhereConditions()
        {
            List<string> catNames = new List<string> { "Lucky", "Bella", "Luna", "Orer" };
            var catsWithA = from cat in catNames
                            where cat.Contains("a") && cat.StartsWith("L")
                            select cat;

            //Another way is using multiplelines
            //var catsWithA = from cat in catNames
            //                where cat.Contains("a")
            //                where cat.StartsWith("L")
            //                select cat;
            Console.WriteLine(string.Join(", ", catsWithA));
        }

        public static void WhereWithSorting()
        {
            int[] numbers = new int[] { 3, 4, 5, 12, 3, 4, 10, 6, 7, 8, 9, 19, 3, 4, 5, 30 };
            var lesThanTenSorted = from number in numbers
                                   where number < 10
                                   orderby number descending
                                   select number;
            Console.WriteLine(string.Join(", ", lesThanTenSorted));

        }
    }
}
 