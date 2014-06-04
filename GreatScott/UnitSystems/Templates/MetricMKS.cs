
using GreatScott.Model;
using System;


namespace GreatScott.UnitSystems.Templates
{
    public static class MetricMKS
    {
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
                return new unit("metres per second", "m/s");
            }
        }

        public static unit Acceleration
        {
            get
            {
                return new unit("metre per second-squared", @"m/s" + (char)253);
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

        public static unit Viscosity
        {
            get
            {
                return new unit("pascal-second", "Pa" + (char)250 + @"s");
            }
        }
    }
}
