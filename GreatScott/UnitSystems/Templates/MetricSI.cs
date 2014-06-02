
using GreatScott.Model;
using System;

namespace GreatScott.UnitSystems.Templates
{
    public static class MetricSI
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
                return new unit("metre", "m");
            }
        }

        public static unit Mass
        {
            get
            {
                return new unit("kilogram", "kg");
            }
        }

        public static unit ElectricCurrent
        {
            get
            {
                return new unit("Ampere", "A");
            }
        }

        public static unit Temperature
        {
            get
            {
                return new unit("kelvin", "K");
            }
        }

        public static unit LuminousIntensity
        {
            get
            {
                return new unit("candela", "cd");
            }
        }

        public static unit AmountOfSubstance
        {
            get
            {
                return new unit("mole", "mol");
            }
        }

        public static unit Area
        {
            get
            {
                return new unit("square metre", @"m" + 253);
            }
        }

        public static unit Acceleration
        {
            get
            {
                return new unit("metre per second-squared", @"m/s" + 253);
            }
        }

        public static unit Frequency
        {
            get
            {
                return new unit("hertz", "Hz");
            }
        }

        public static unit Energy
        {
            get
            {
                return new unit("joule", "J");
            }
        }

        public static unit Power
        {
            get
            {
                return new unit("watt", "W");
            }
        }

        public static unit Force
        {
            get
            {
                return new unit("newton", "N");
            }
        }

        public static unit Pressure
        {
            get
            {
                return new unit("pascal", "Pa");
            }
        }

        public static unit ElectricCharge
        {
            get
            {
                return new unit("coulomb", "C");
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
                return new unit("farad", "F");
            }
        }

        public static unit Inductance
        {
            get
            {
                return new unit("henry", "H");
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
                return new unit("siemens", "S");
            }
        }

        public static unit MagneticFlux
        {
            get
            {
                return new unit("weber", "Wb");
            }
        }

        public static unit MagneticFluxDensity
        {
            get
            {
                return new unit("tesla", "T");
            }
        }

        public static unit MagneticFieldStrength
        {
            get
            {
                return new unit("ampere-metre", "A/m");
            }
        }

        public static unit DynamicViscosity
        {
            get
            {
                return new unit("pascal-second", "Pa" + 250 + @"s");
            }
        }

        public static unit KinematicViscosity
        {
            get
            {
                return new unit("square metres per second", @"m" + 253 + @"/s");
            }
        }

        public static unit LuminousFlux
        {
            get
            {
                return new unit("lumen", "lm");
            }
        }

        public static unit Illuminance
        {
            get
            {
                return new unit("lux", "lx");
            }
        }

        public static unit Radioactivity
        {
            get
            {
                return new unit("becquerel", "Bq");
            }
        }

        public static unit AbsorbedRadiationDose
        {
            get
            {
                return new unit("gray", "Gy");
            }
        }

        public static unit RadiationDoseEquivalent
        {
            get
            {
                return new unit("sievert", String.Empty);
            }
        }

        public static unit CatalyticActivity
        {
            get
            {
                return new unit("katal", "kat");
            }
        }

    }
}
