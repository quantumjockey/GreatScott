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
        ObservableCollection<unit> AvailableUnits { get; set; }
        unit SelectedUnit { get; set; }
    }
}
