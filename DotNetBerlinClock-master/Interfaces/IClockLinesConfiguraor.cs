using BerlinClock.Types;
using System.Collections.Generic;

namespace BerlinClock.Interfaces
{
    public interface IClockLinesConfiguraor
    {
        IEnumerable<ClockLineConfiguration> ClockLinesConfiguration { get; }
    }
}
