﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakes = new Queue<Sweepstakes>();

        void ISweepstakesManager.InsertSweepStakes(Sweepstakes sweepstakes)
        {
            this.sweepstakes.Enqueue(sweepstakes);
        }
        
        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return sweepstakes.Dequeue();
        }
    }
}
