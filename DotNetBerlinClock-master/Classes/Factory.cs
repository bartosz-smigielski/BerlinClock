using BerlinClock.Interfaces;
 
namespace BerlinClock.Classes
{
    public class Factory : IFactory
    {
        public ILineBuilder GetLineBuilder(char[] lights, char defaultFilling, int lineLength)
        {
            return new LineBuilder(lights, lineLength, defaultFilling);
        }

        public IInputParser GetInputParser()
        {
            return new InputParser();
        }

        public ILinesMerger GetLinesMerger()
        {
            return new LinesMerger();
        }

        public IClockLinesConfiguraor GetClockLinesConfigurator()
        {
            return new BerlinClockLinesConfigurator();
        }
    }
}
