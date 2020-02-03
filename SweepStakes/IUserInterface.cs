using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class IUserInterface
    {
        
        public static Contestant GetUserInfo()
        {
            Contestant contestant = new Contestant();
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

        public static ISweepstakesManager PickManager()
        {
            ISweepstakesManager pickManager;
            string pick;
            do
            {
                Console.WriteLine("How would you like your sweepstakes to be managed? stack or queue?");
                pick = Console.ReadLine().ToLower();
            }
            while (pick != "stack" && pick != "queue");
            if(pick == "stack")
            {
                pickManager = new SweepstakesStackManager();
                return pickManager;
            }
            else if(pick == "queue")
            {
                pickManager = new SweepstakesQueueManager();
                return pickManager;
            }
            return null;
        }

        public static string SetSweepstake()
        {
            Console.Clear();
            Console.WriteLine("What is the name of sweepstake?");
            return Console.ReadLine();
        }

        public static void AnnouceWinner(Sweepstakes sweepstakes)
        {
            Console.WriteLine("The winner of the Sweepstakes is: " + sweepstakes.name);
        }



    }
}
