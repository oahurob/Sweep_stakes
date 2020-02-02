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
            contestant.FirstName = IUserInterface.GetUserFirstName();
            contestant.LastName = IUserInterface.GetUserLastName();
            contestant.EmailAddress = IUserInterface.GetUserEmail();
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
            IUserInterface.PrintUserInfo(contestant);
        }
    }
}
