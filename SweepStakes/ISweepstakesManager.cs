﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface ISweepstakesManager
    {
            void InsertSweepStakes(Sweepstakes sweepstakes);
            Sweepstakes GetSweepstakes();
    }
}
