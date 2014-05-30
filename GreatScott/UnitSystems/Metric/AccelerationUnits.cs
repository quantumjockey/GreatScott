///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using GreatScott.UnitSystems.Base;

#endregion
///////////////////////////////////////

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
