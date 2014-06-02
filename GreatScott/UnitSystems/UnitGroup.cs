///////////////////////////////////////
#region Namespace Directives

using GreatScott.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#endregion
///////////////////////////////////////

namespace GreatScott.UnitSystems
{
    public class UnitGroup
    {
        ////////////////////////////////////////
        #region Fields

        private ReadOnlyObservableCollection<unit> _prefixes;

        #endregion

        ////////////////////////////////////////
        #region Properties

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

        #endregion

        ////////////////////////////////////////
        #region Constructor

        public UnitGroup(string unitString) : this(unitString, 0, 12) { }

        public UnitGroup(string _unitString, int _first, int _last)
        {
            _prefixes = new ReadOnlyObservableCollection<unit>(GenerateUnitMultipliers());
            AvailableUnits = new ObservableCollection<unit>(AddUnitBody(_unitString, _first, _last));
            SelectedUnit = SelectDefault();
        }

        #endregion

        ////////////////////////////////////////
        #region Supporting Methods

        protected List<unit> AddUnitBody(string body, int first, int last)
        {
            List<unit> set = new List<unit>();
            int count = _prefixes.Count;
            int frst = (first > 0) ? first : 0;
            int lst = (last < count) ? last : (count - 1);

            for (int i = frst; i <= lst; i++)
            {
                unit item = _prefixes[i];
                item.AddBody(body);
                set.Add(item);
            }

            return set;
        }

        private ObservableCollection<unit> GenerateUnitMultipliers()
        {
            ObservableCollection<unit> _baseUnits = new ObservableCollection<unit>();
            _baseUnits.Add(new unit(0.000000000001, "T"));
            _baseUnits.Add(new unit(0.000000001, "G"));
            _baseUnits.Add(new unit(0.000001, "M"));
            _baseUnits.Add(new unit(0.001, "k"));
            _baseUnits.Add(new unit(0.01, "h"));
            _baseUnits.Add(new unit(0.1, "da"));
            _baseUnits.Add(new unit(1.0, String.Empty));
            _baseUnits.Add(new unit(10.0, "d"));
            _baseUnits.Add(new unit(100.0, "c"));
            _baseUnits.Add(new unit(1000.0, "m"));
            _baseUnits.Add(new unit(1000000.0, "μ"));
            _baseUnits.Add(new unit(1000000000.0, "n"));
            _baseUnits.Add(new unit(1000000000000.0, "p"));
            return _baseUnits;
        }

        private unit SelectDefault()
        {
            int count = AvailableUnits.Count;
            int mid = (count > 1) ? (count / 2) : 0;
            return AvailableUnits[mid];
        }

        #endregion
    }
}
