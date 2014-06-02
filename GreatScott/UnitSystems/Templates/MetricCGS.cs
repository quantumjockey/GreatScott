
using GreatScott.Model;
using System;

namespace GreatScott.UnitSystems.Templates
{
    public static class MetricCGS
    {
        public static unit Displacement
        {
            get
            {
                return new unit("centimetre", "cm");
            }
        }

        public static unit Mass
        {
            get
            {
                return new unit("gram", "g");
            }
        }

        public static unit Time
        {
            get
            {
                return new unit("second", "s");
            }
        }

        public static unit Velocity
        {
            get
            {
                return new unit("centimetres per second", "cm/s");
            }
        }

        public static unit Acceleration
        {
            get
            {
                return new unit("gal", "Gal");
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
                return new unit("barye", "Ba");
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
                return new unit("erg per second", "erg/s");
            }
        }

        public static unit Viscosity
        {
            get
            {
                return new unit("poise", "p");
            }
        }
    }
}
