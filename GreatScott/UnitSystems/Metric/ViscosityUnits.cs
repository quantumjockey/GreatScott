///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using GreatScott.UnitSystems.Base;

#endregion
///////////////////////////////////////

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
