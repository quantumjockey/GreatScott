
namespace GreatScott.Model
{
    public class unit
    {
        public double Multiplier
        {
            get;
            private set;
        }

        public string Symbol
        {
            get;
            set;
        }

        public unit(double _multiplier, string _symbol)
        {
            Multiplier = _multiplier;
            Symbol = _symbol;
        }
    }
}
