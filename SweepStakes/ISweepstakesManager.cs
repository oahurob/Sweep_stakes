using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public abstract class ISweepstakesManager
    {
            public abstract void InsertSweepStakes(Sweepstakes sweepstakes);
            public abstract Sweepstakes GetSweepstakes();
    }
}
