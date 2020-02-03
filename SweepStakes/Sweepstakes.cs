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
        public List<string> contestantsNames = new List<string>();
        Random winningNumber = new Random();
        public string name;
        public string Name;
        private int registrationID;
        public int winnerKey;
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = registrationID;
            contestants.Add(registrationID, contestant);
            registrationID++;
        }
        public Contestant PickWinner()
        {
            Contestant winner;
            winner = contestants[winningNumber.Next(0, contestants.Keys.Count)];
            name = winner.FirstName + " " + winner.LastName;
            winnerKey = winner.registrationNumber;
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
                Console.WriteLine("Contestant name: " + contestant.FirstName + " " + contestant.LastName + ", ");
                Console.Write("email: " + contestant.EmailAddress + ", ");
                Console.Write("registration number: " + contestant.registrationNumber);
                Console.ReadLine();
        }

        
    }
}
