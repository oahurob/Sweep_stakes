using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface IContestant
    {
        string Name { get; set; }

        void Notify(IContestant contestant);
    }
}
