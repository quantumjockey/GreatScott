
using GreatScott.Model;
using System;

namespace GreatScott.UnitSystems.Templates
{
    public static class MetricLegacy
    {

        public static unit Time
        {
            get
            {
                return new unit("second", "s");
            }
        }

        public static unit Displacement
        {
            get
            {
                return new unit("centimetre", "cm");
            }
        }

        public static unit MicroscopicLength
        {
            get
            {
                return new unit("ångström", "Å");
            }
        }

        public static unit Mass
        {
            get
            {
                return new unit("gram", "g");
            }
        }

        public static unit ElectricCurrent
        {
            get
            {
                return new unit("ampere", "A");
            }
        }

        public static unit Temperature
        {
            get
            {
                return new unit("centigrade", "°C");
            }
        }

        public static unit LuminousIntensity
        {
            get
            {
                return new unit("candela", "cd");
            }
        }

        public static unit Area
        {
            get
            {
                return new unit("are", "are");
            }
        }

        public static unit Acceleration
        {
            get
            {
                return new unit("gal", "gal");
            }
        }

        public static unit Frequency
        {
            get
            {
                return new unit("cycles per second", "cycles/s");
            }
        }

        public static unit Energy
        {
            get
            {
                return new unit("erg", "erg");
            }
        }

        public static unit Power
        {
            get
            {
                return new unit("horsepower", "HP");
            }
        }

        public static unit Force
        {
            get
            {
                return new unit("dyne", "dyn");
            }
        }

        public static unit Pressure
        {
            get
            {
                return new unit("atmosphere", "at");
            }
        }

        public static unit ElectricCharge
        {
            get
            {
                return new unit("abcoulomb", "aC");
            }
        }

        public static unit ElectricPotential
        {
            get
            {
                return new unit("volt", "V");
            }
        }

        public static unit Capacitance
        {
            get
            {
                return new unit("abfarad", "aF");
            }
        }

        public static unit Inductance
        {
            get
            {
                return new unit("abhenry", "aH");
            }
        }

        public static unit ElectricResistance
        {
            get
            {
                return new unit("ohm", "Ω");
            }
        }

        public static unit ElectricConductance
        {
            get
            {
                return new unit("mho", "℧");
            }
        }

        public static unit MagneticFlux
        {
            get
            {
                return new unit("maxwell", "Mx");
            }
        }

        public static unit MagneticFluxDensity
        {
            get
            {
                return new unit("gauss", "G");
            }
        }

        public static unit MagneticFieldStrength
        {
            get
            {
                return new unit("oersted", "Oe");
            }
        }

        public static unit DynamicViscosity
        {
            get
            {
                return new unit("poise", "P");
            }
        }

        public static unit KinematicViscosity
        {
            get
            {
                return new unit("stokes", "St");
            }
        }

        public static unit LuminousFlux
        {
            get
            {
                return new unit("stilb", "sb");
            }
        }

        public static unit Illuminance
        {
            get
            {
                return new unit("phot", "ph");
            }
        }

        public static unit Radioactivity
        {
            get
            {
                return new unit("curie", "Ci");
            }
        }

        public static unit AbsorbedRadiationDose
        {
            get
            {
                return new unit("roentgen", "R");
            }
        }

        public static unit RadiationDoseEquivalent
        {
            get
            {
                return new unit("roentgen equivalent man", "rem");
            }
        }
    }
}
