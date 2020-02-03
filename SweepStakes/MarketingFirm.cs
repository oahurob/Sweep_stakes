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
            Console.WriteLine("Do you want to enter another person? 'yes' or 'no'");
            more = Console.ReadLine();
            while(more == "yes")
            {
                sweepstakes.RegisterContestant(IUserInterface.GetUserInfo());
                manager.InsertSweepStakes(sweepstakes);
                Console.WriteLine("Do you want to enter another person? 'yes' or 'no'");
                more = Console.ReadLine();
            }
            sweepstakes.PickWinner();
            IUserInterface.AnnouceWinner(sweepstakes);
        }
    }
}
