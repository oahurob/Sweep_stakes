using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> Sweepstakes = new Stack<Sweepstakes>();

        public override void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            this.Sweepstakes.Push(sweepstakes);
        }
        public override Sweepstakes GetSweepstakes()
        {
            return Sweepstakes.Pop();
        }
    }
}
