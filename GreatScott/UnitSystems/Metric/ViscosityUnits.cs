using GreatScott.Model;

namespace GreatScott.UnitSystems.Metric
{
    public class ViscosityUnits : UnitGroup
    {
        public ViscosityUnits()
        {
            AddUnitBody(@"Pa" + 250 + @"s");
        }
    }
}
