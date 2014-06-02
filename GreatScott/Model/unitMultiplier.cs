
namespace GreatScott.Model
{
    public class unitMultiplier
    {
        ////////////////////////////////////////
        #region Properties

        public double Multiplier
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

        public unitMultiplier(double _multiplier, string _symbol)
        {
            Multiplier = _multiplier;
            Symbol = _symbol;
        }

        #endregion

        ////////////////////////////////////////
        #region Public Methods

        public void AddBody(string _body)
        {
            Symbol += _body;
        }

        #endregion
    }
}
