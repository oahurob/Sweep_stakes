using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        string firstName;
        string lastName;
        string emailAddress;
        public int registrationNumber;

        public Contestant(int registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }

    }
}
