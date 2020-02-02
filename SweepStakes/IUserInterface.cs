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
            Console.Write("please enter your last name: ");
            return Console.ReadLine();
        }
        public static string GetUserEmail()
        {
            Console.Write("Please enter your email address: ");
            return Console.ReadLine();
        }

        public static string PickManager()
        {
            string pick;
            do
            {
                Console.WriteLine("How would you like your sweepstakes to be managed? stack or queue?");
                pick = Console.ReadLine();
            }
            while (pick != "stack" && pick != "queue");
            return pick;
        }
    

        public static void PrintUserInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant name: " + contestant.FirstName + " " + contestant.LastName + ", ");
            Console.Write("email: " + contestant.EmailAddress + ", ");
            Console.Write("registration number: " + contestant.registrationNumber);
            Console.ReadLine();
        }

        public static void AnnouceWinner(Sweepstakes sweepstakes)
        {
            Console.WriteLine("The winner of the Sweepstakes is: " + sweepstakes.PickWinner());
        }



    }
}
