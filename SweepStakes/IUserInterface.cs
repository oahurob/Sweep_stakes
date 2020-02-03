using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class IUserInterface
    {
        
        public static Contestant GetUserFirstName(Contestant contestant)
        {
            Console.Write("Please enter your First name: ");
            contestant.FirstName = Console.ReadLine();
            Console.Write("please enter your last name: ");
            contestant.LastName = Console.ReadLine();
            Console.Write("Please enter your email address: ");
            contestant.EmailAddress = Console.ReadLine();
            return contestant;
        }

        public static string SweepstakesName()
        {
            Console.WriteLine("What would you like to name this sweepstakes?");
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

        public static string SetSweepstake()
        {
            Console.Clear();
            Console.WriteLine("What is the name of sweepstake?");
            return Console.ReadLine();
        }

        public static int SetAmountOfContestants()
        {
            string amount;
            int result;
            do
            {
                Console.Clear();
                Console.WriteLine("How many contestants are entering?");
                amount = Console.ReadLine();
            } while (Int32.TryParse(amount, out result) == false);
            return result;
        }

        public static int SetAmountOfSweepstakes()
        {
            string amount;
            int result;
            do
            {
                Console.Clear();
                Console.WriteLine("How many sweepstakes do you want to input?");
                amount = Console.ReadLine();
            } while (Int32.TryParse(amount, out result) == false);
            return result;
        }

        public static void AnnouceWinner(Sweepstakes sweepstakes)
        {
            Console.WriteLine("The winner of the Sweepstakes is: " + sweepstakes.PickWinner());
        }



    }
}
