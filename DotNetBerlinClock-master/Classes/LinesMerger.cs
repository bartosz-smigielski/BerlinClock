using BerlinClock.Interfaces;
using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public class LinesMerger : ILinesMerger
    {
        public string Merge(IEnumerable<string> lines)
        {
            return string.Join("\r\n", lines);
        }
    }

}
