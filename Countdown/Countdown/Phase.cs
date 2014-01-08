using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown
{
    public abstract class Phase
    {
        abstract internal Player[] GetScores();
    }
}
