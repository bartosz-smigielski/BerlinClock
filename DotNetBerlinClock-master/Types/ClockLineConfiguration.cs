using System;
using System.Collections.Generic;

namespace BerlinClock.Types
{
    public class ClockLineConfiguration
    {
        public TimePart TimePart { get; set; }

        public int LineLength { get; set; }

        public char DefaultFilling { get; set; }

        public IEnumerable<char> Lights { get; set; }

        public Func<int, int> NormalizeFunction { get; set; }
    }
}
