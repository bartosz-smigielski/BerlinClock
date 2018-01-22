using System.Collections.Generic;

namespace BerlinClock.Interfaces
{
    public interface ILinesMerger
    {
        string Merge(IEnumerable<string> lines);
    }
}
