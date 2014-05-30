///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using GreatScott.UnitSystems.Base;

#endregion
///////////////////////////////////////

namespace GreatScott.UnitSystems.Metric
{
    public class EnergyUnits : EnergyGroup
    {
        public EnergyUnits()
        {
            AddUnitBody("J");
        }
    }
}
