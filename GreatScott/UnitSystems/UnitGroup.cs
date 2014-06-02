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

        private ReadOnlyObservableCollection<unitMultiplier> _prefixes;

        #endregion

        ////////////////////////////////////////
        #region Properties

        public unitMultiplier SelectedUnit
        {
            get;
            set;
        }

        public ObservableCollection<unitMultiplier> AvailableUnits
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
            _prefixes = new ReadOnlyObservableCollection<unitMultiplier>(GenerateUnitMultipliers());
            AvailableUnits = new ObservableCollection<unitMultiplier>(AddUnitBody(_unitString, _first, _last));
            SelectedUnit = SelectDefault();
        }

        #endregion

        ////////////////////////////////////////
        #region Supporting Methods

        protected List<unitMultiplier> AddUnitBody(string body, int first, int last)
        {
            List<unitMultiplier> set = new List<unitMultiplier>();
            int count = _prefixes.Count;
            int frst = (first > 0) ? first : 0;
            int lst = (last < count) ? last : (count - 1);

            for (int i = frst; i <= lst; i++)
            {
                unitMultiplier item = _prefixes[i];
                item.AddBody(body);
                set.Add(item);
            }

            return set;
        }

        private ObservableCollection<unitMultiplier> GenerateUnitMultipliers()
        {
            ObservableCollection<unitMultiplier> _baseUnits = new ObservableCollection<unitMultiplier>();
            _baseUnits.Add(new unitMultiplier(0.000000000001, "T"));
            _baseUnits.Add(new unitMultiplier(0.000000001, "G"));
            _baseUnits.Add(new unitMultiplier(0.000001, "M"));
            _baseUnits.Add(new unitMultiplier(0.001, "k"));
            _baseUnits.Add(new unitMultiplier(0.01, "h"));
            _baseUnits.Add(new unitMultiplier(0.1, "da"));
            _baseUnits.Add(new unitMultiplier(1.0, String.Empty));
            _baseUnits.Add(new unitMultiplier(10.0, "d"));
            _baseUnits.Add(new unitMultiplier(100.0, "c"));
            _baseUnits.Add(new unitMultiplier(1000.0, "m"));
            _baseUnits.Add(new unitMultiplier(1000000.0, "μ"));
            _baseUnits.Add(new unitMultiplier(1000000000.0, "n"));
            _baseUnits.Add(new unitMultiplier(1000000000000.0, "p"));
            return _baseUnits;
        }

        private unitMultiplier SelectDefault()
        {
            int count = AvailableUnits.Count;
            int mid = (count > 1) ? (count / 2) : 0;
            return AvailableUnits[mid];
        }

        #endregion
    }
}
