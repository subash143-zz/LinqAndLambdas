using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Exercises
{
    public class Exercise9 : IExercise
    {
        //Question
        //Perform Inner Join between two collection
        public void Run()
        {
            #region Data
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = terry };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };
            #endregion
            // Create two lists.
            List<Person> people = new List<Person> { magnus, terry, charlotte, arlene };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            var innerJoin = from person in people
                            join pet in pets on person equals pet.Owner
                            select new
                            {
                                Owner = pet.Owner,
                                Pet = pet.Name
                            };

            foreach (var ownerAndPet in innerJoin)
            {
                Console.WriteLine($"\"{ownerAndPet.Pet}\" is owned by {ownerAndPet.Owner.FirstName} {ownerAndPet.Owner.LastName}");
            }

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }
}
