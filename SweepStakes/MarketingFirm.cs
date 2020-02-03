using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        private ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepStakes()
        {
            string more = "yes";
            Sweepstakes sweepstakes = new Sweepstakes(IUserInterface.SweepstakesName());
            sweepstakes.RegisterContestant(IUserInterface.GetUserInfo());
            more = Console.ReadLine();
            while(more == "yes")
            {
                sweepstakes.RegisterContestant(IUserInterface.GetUserInfo());
                more = Console.ReadLine();
                manager.InsertSweepStakes(sweepstakes);
            }
            sweepstakes.PickWinner();
            IUserInterface.AnnouceWinner(sweepstakes);
        }
    }
}
