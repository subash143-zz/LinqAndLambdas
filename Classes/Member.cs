using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas.Classes
{
    public class Member
    {
        public int PersonId;
        public string Position;

        public Member(int PersonId, string Position)
        {
            this.PersonId = PersonId;
            this.Position = Position;
        }

    }
}
