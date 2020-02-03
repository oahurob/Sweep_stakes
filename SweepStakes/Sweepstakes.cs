using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random winningNumber = new Random();
        private string name;
        public string Name;
        private int registrationID;
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            IUserInterface.GetUserFirstName(contestant);
            contestant.registrationNumber = registrationID;
            contestants.Add(registrationID, contestant);
            registrationID++;
        }
        public Contestant PickWinner()
        {
            Contestant winner;
            winner = contestants[winningNumber.Next(0, contestants.Keys.Count)];
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            for (int i = 0; i < contestants.Count(); i++)
            {
                Console.WriteLine("Contestant name: " + contestant.FirstName + " " + contestant.LastName + ", ");
                Console.Write("email: " + contestant.EmailAddress + ", ");
                Console.Write("registration number: " + contestant.registrationNumber);
                Console.ReadLine();
            }
        }
    }
}
