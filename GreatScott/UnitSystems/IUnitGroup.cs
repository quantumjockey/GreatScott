///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using System.Collections.ObjectModel;

#endregion
///////////////////////////////////////

namespace GreatScott.UnitSystems
{
    interface IUnitGroup
    {
        // Property signatures
        ObservableCollection<unitMultiplier> AvailableUnits { get; set; }
        unitMultiplier SelectedUnit { get; set; }
    }
}
