﻿///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using GreatScott.UnitSystems.Base;

#endregion
///////////////////////////////////////

namespace GreatScott.UnitSystems.Metric
{
    public class MassUnits : MassGroup
    {
        public MassUnits()
        {
            AddUnitBody("g");
        }
    }
}
