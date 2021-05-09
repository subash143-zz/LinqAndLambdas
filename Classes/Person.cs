using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Classes
{
    public class Person
    {
        public int PersonId;
        public string Name;
        public int Age;
        public bool IsVeteran;
        public Person(string Name, int Age, bool isVeteran = false)
        {
            this.Name = Name;
            this.Age = Age;
            this.IsVeteran = isVeteran;
        }

        public Person(int PersonId, string Name, int Age)
        {
            this.PersonId = PersonId;
            this.Name = Name;
            this.Age = Age;
        }

    }
}
