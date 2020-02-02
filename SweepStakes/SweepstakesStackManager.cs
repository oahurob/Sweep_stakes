using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> Sweepstakes = new Stack<Sweepstakes>();

        void ISweepstakesManager.InsertSweepStakes(Sweepstakes sweepstakes)
        {
            this.Sweepstakes.Push(sweepstakes);
        }
        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return Sweepstakes.Pop();
        }
    }
}
