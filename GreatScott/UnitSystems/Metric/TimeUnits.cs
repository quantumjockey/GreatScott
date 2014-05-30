u///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using GreatScott.UnitSystems.Base;

#endregion
///////////////////////////////////////

namespace GreatScott.UnitSystems.Metric
{
    public class TimeUnits : TimeGroup
    {
        public TimeUnits()
        {
            AddUnitBody("s");
        }
    }
}
