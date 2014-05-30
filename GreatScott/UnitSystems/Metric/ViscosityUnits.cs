using GreatScott.Model;
using GreatScott.UnitSystems.Base;

namespace GreatScott.UnitSystems.Metric
{
    public class ViscosityUnits : ViscosityGroup
    {
        public ViscosityUnits()
        {
            AddUnitBody(@"Pa" + 250 + @"s");
        }
    }
}
