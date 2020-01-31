using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class IUserInterface
    {

        public static string GetUserFirstName()
        {
            Console.Write("Please enter your First name: ");
            return Console.ReadLine();
        }

        public static string GetUserLastName()
        {
            Console.Write("Please enter your Last name: ");
            return Console.ReadLine();
        }

        public static string GetUserEmail()
        {
            Console.Write("Please enter your email address: ");
            return Console.ReadLine();
        }


    }
}
