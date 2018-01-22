using BerlinClock.Types;
 

namespace BerlinClock.Interfaces
{
    public interface IInputParser
    {
         int Parse(string input, TimePart timePart);
    }
}
