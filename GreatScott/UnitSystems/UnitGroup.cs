using GreatScott.Model;
using System.Collections.ObjectModel;

namespace GreatScott.UnitSystems
{
    public class UnitGroup
    {
        public ObservableCollection<unit> AvailableUnits
        {
            get;
            set;
        }

        public UnitGroup()
        {
            AvailableUnits = new ObservableCollection<unit>();
        }
    }
}
