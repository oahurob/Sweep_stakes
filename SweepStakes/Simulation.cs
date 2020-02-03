using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Simulation
    {
        public Simulation()
        {

        }
        
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager sweepstakesManager;
            sweepstakesManager = IUserInterface.PickManager();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
            marketingFirm.CreateSweepStakes();
        }
    }
}
