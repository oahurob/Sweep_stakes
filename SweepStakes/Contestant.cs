using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant : IContestant
    {
        string firstName;
        string lastName;
        string emailAddress;
        public int registrationNumber;
        public string Name { get { return Name; } set { Name = FirstName; } }

        public Contestant()
        {
        }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }

        public void Notify(IContestant contestant)
        {
            Console.WriteLine("Thank you, {0} for entering", contestant.Name);
        }

    }
}
