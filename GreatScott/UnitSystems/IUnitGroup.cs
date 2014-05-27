using GreatScott.Model;
using System.Collections.ObjectModel;

namespace GreatScott.UnitSystems
{
    interface IUnitGroup
    {
        ObservableCollection<unit> AvailableUnits { get; set; }
        unit SelectedUnit { get; set; }
    }
}
