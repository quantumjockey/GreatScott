using GreatScott.Model;

namespace GreatScott.UnitSystems.Metric
{
    public class PressureUnits : UnitGroup
    {
        public PressureUnits()
        {
            AvailableUnits.Add(new unit(1.0, "Pa"));
            AvailableUnits.Add(new unit(0.001, "kPa"));
            AvailableUnits.Add(new unit(0.000001, "MPa"));
            AvailableUnits.Add(new unit(0.000000001, "GPa"));
        }
    }
}
