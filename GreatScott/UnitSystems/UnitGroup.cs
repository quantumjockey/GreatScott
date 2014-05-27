using GreatScott.Model;
using System;
using System.Collections.ObjectModel;

namespace GreatScott.UnitSystems
{
    public class UnitGroup
    {
        public unit SelectedUnit
        {
            get;
            set;
        }

        public ObservableCollection<unit> AvailableUnits
        {
            get;
            set;
        }

        public UnitGroup()
        {
            AvailableUnits = new ObservableCollection<unit>();
            PopulateUnitMultipliers();
        }

        protected void AddUnitBody(string _body)
        {
            foreach (unit item in AvailableUnits)
            {
                item.AddBody(_body);
            }

            SelectedUnit = AvailableUnits[6];
        }

        private void PopulateUnitMultipliers()
        {
            AvailableUnits.Add(new unit(0.000000000001, "T"));
            AvailableUnits.Add(new unit(0.000000001, "G"));
            AvailableUnits.Add(new unit(0.000001, "M"));
            AvailableUnits.Add(new unit(0.001, "k"));
            AvailableUnits.Add(new unit(0.01, "h"));
            AvailableUnits.Add(new unit(0.1, "da"));
            AvailableUnits.Add(new unit(1.0, String.Empty));
            AvailableUnits.Add(new unit(10.0, "d"));
            AvailableUnits.Add(new unit(100.0, "c"));
            AvailableUnits.Add(new unit(1000.0, "m"));
            AvailableUnits.Add(new unit(1000000.0, "μ"));
            AvailableUnits.Add(new unit(1000000000.0, "n"));
            AvailableUnits.Add(new unit(1000000000000.0, "p"));
        }

    }
}
