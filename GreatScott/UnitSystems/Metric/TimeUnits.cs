using GreatScott.Model;

namespace GreatScott.UnitSystems.Metric
{
    public class TimeUnits : UnitGroup
    {
        public TimeUnits()
        {
            AvailableUnits.Add(new unit(1.0, "s"));
            AvailableUnits.Add(new unit(1000.0, "ms"));
            AvailableUnits.Add(new unit(1000000.0, "μs"));
        }
    }
}
