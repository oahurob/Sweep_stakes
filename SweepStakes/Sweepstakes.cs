using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestant;
        private string name;
        public string Name;
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public void PickWinner() //change to return Contestant
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
