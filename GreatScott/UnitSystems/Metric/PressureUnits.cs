///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using GreatScott.UnitSystems.Base;

#endregion
///////////////////////////////////////

namespace GreatScott.UnitSystems.Metric
{
    public class PressureUnits : PressureGroup
    {
        public PressureUnits()
        {
            AddUnitBody("Pa");
        }
    }
}
