using GreatScott.Model;

namespace GreatScott.UnitSystems.Metric
{
    public class DistanceUnits : UnitGroup
    {
        public DistanceUnits()
        {
            AvailableUnits.Add(new unit(1.0, "m"));
            AvailableUnits.Add(new unit(100.0, "cm"));
            AvailableUnits.Add(new unit(1000.0, "mm"));
            AvailableUnits.Add(new unit(1000000.0, "μm"));
        }
    }
}
