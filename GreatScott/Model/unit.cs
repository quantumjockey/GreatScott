﻿
namespace GreatScott.Model
{
    public class unit
    {
        ////////////////////////////////////////
        #region Properties

        public string Name
        {
            get;
            private set;
        }

        public string Symbol
        {
            get;
            private set;
        }

        #endregion

        ////////////////////////////////////////
        #region Constructor

        public unit(string _name, string _symbol)
        {
            Name = _name;
            Symbol = _symbol;
        }

        #endregion
    }
}
