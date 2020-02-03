using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakes = new Queue<Sweepstakes>();

        public override void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            this.sweepstakes.Enqueue(sweepstakes);
        }
        
        public override Sweepstakes GetSweepstakes()
        {
            return sweepstakes.Dequeue();
        }
    }
}
