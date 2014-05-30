using GreatScott.Model;
using GreatScott.UnitSystems.Base;

namespace GreatScott.UnitSystems.Metric
{
    public class AccelerationUnits : AccelerationGroup
    {
        public AccelerationUnits()
        {
            AddUnitBody(@"m/s" + 253);
        }
    }
}
