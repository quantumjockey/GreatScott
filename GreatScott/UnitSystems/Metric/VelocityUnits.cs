///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using GreatScott.UnitSystems.Base;

#endregion
///////////////////////////////////////
namespace GreatScott.UnitSystems.Metric
{
    public class VelocityUnits : VelocityGroup
    {
        public VelocityUnits()
        {
            AddUnitBody("m/s");
        }
    }
}
