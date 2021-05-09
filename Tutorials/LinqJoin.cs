using LinqAndLambdas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    public static class LinqJoin
    {
        public static List<Person> people = new List<Person>
        {
            new Person(1, "Subash", 26),
            new Person(2, "Pradip", 25),
            new Person(3, "Pradip", 27),
            new Person(4, "Rimal", 27),
            new Person(5, "Psychonated", 24),
            new Person(6, "Nirajan", 32)
        };

        public static List<Member> members = new List<Member>
        {
            new Member(2, "Secretary"),
            new Member(3, "President"),
            new Member(5, "Vice-President"),
            new Member(7, "Member"),
            new Member(8, "Foreign Affairs Manager"),
            new Member(1, "Sales and Marketing"),
        };


        public static void InnerJoinLambda()
        {
            //For Composite Join i.e. Join with multiple keys, use p=> new {//Properties to Join}, m=>{//Properties to Join} 
            var innerJoin = people.Join(members, p => p.PersonId, m => m.PersonId, (p, m) =>
              new {
                  Name = p.Name,
                  Position = m.Position
              });

            foreach(var item in innerJoin)
            {
                Console.WriteLine($"Name: {item.Name}, Position: {item.Position}");
            }
        }

        public static void InnerJoinLinq()
        {
            var innerJoin = from person in people
                            join member in members on person.PersonId equals member.PersonId
                            select new
                            {
                                Name = person.Name,
                                Position = member.Position
                            };
            foreach (var item in innerJoin)
            {
                Console.WriteLine($"Name: {item.Name}, Position: {item.Position}");
            }
        }





    }
}
