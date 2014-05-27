using GreatScott.Model;

namespace GreatScott.UnitSystems.Metric
{
    public class VelocityUnits : UnitGroup
    {
        public VelocityUnits()
        {
            AvailableUnits.Add(new unit(1.0, "m/s"));
            AvailableUnits.Add(new unit(0.001, "km/s"));
        }
    }
}
