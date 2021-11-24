using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winUnitConverter
{
    class Converter
    {

        public static double convert(double value, string unit1, string unit2 )
        {
            //lenght
            double kmMiles = 0.621371;
            double kmYard = 1093.61;
            double kmFoot = 3280.84;
            double kmInches = 39370.1;
            double kmm = 1000;
            double kmcm = 100000;
            double kmmm = 1000000;

            //mass
            double kgStone = 0.157473;
            double kgPounds = 2.20462;
            double kgOunce = 35.274;
            double kgg = 1000;
            //temperature converter
            double cF = (value * 9 / 5) + 32;
            double fC = (value - 32) * 5 / 9;
            double cK = value + 273.15;
            double kC = value - 273.15;

            switch (unit1)
            {
                //lenght converters
                case "Kilometer":
                    switch (unit2)
                    {
                        case "Meter":return value * kmm;
                        case "Centimeter":return value * kmcm;
                        case "Milimeter":; return value * kmmm;
                        case "Mile":; return value * kmMiles;
                        case "Yard": return value * kmYard;
                        case "Foot": return value * kmFoot;
                        case "Inch": return value * kmInches;
                    };break;
                case "Meter":
                    switch (unit2)
                    {
                        case "Kilometer": return (value / kmm);
                        case "Centimeter": return (value / kmm) * kmcm;
                        case "Milimeter":; return (value / kmm) * kmmm;
                        case "Mile": return (value / kmm) * kmMiles;
                        case "Yard": return (value / kmm) * kmYard;
                        case "Foot": return (value / kmm) * kmFoot;
                        case "Inch": return (value / kmm) * kmInches;
                    }; break;
                case "Centimeter":
                    switch (unit2)
                    {
                        case "Kilometer": return (value / kmcm);
                        case "Meter": return (value / kmcm) * kmm;
                        case "Milimeter": return (value / kmcm) * kmmm;
                        case "Mile": return (value / kmcm) * kmMiles;
                        case "Yard": return (value / kmcm) * kmYard;
                        case "Foot": return (value / kmcm) * kmFoot;
                        case "Inch": return (value / kmcm) * kmInches;
                    }; break;
                case "Milimeter":
                    switch (unit2)
                    {
                        case "Kilometer": return (value / kmmm);
                        case "Centimeter": return (value / kmmm) * kmcm;
                        case "Meter": return (value / kmmm) * kmm;
                        case "Mile": return (value / kmmm) * kmMiles;
                        case "Yard": return (value / kmmm) * kmYard;
                        case "Foot": return (value / kmmm) * kmFoot;
                        case "Inch": return (value / kmmm) * kmInches;
                    }; break;
                case "Mile":
                    switch (unit2)
                    {
                        case "Kilometer": return (value / kmMiles);
                        case "Centimeter":; return (value / kmMiles) * kmcm;
                        case "Milimeter": return (value / kmMiles) * kmmm;
                        case "Meter":; return (value / kmMiles) * kmm;
                        case "Yard": return (value / kmMiles) * kmYard;
                        case "Foot": return (value / kmMiles) * kmFoot;
                        case "Inch": return (value / kmMiles) * kmInches;
                    }; break;
                case "Yard":
                    switch (unit2)
                    {
                        case "Kilometer": return (value / kmYard);
                        case "Centimeter": return (value / kmYard) * kmcm;
                        case "Milimeter": return (value / kmYard) * kmmm;
                        case "Mile": return (value / kmYard) * kmMiles;
                        case "Meter": return (value / kmYard) * kmm;
                        case "Foot": return (value / kmYard) * kmFoot;
                        case "Inch": return (value / kmYard) * kmInches;
                    }; break;
                case "Foot":
                    switch (unit2)
                    {
                        case "Kilometer": return (value / kmFoot);
                        case "Centimeter": return (value / kmFoot) * kmcm;
                        case "Milimeter": return (value / kmFoot) * kmmm;
                        case "Mile": return (value / kmFoot) * kmMiles;
                        case "Yard": return (value / kmFoot) * kmYard;
                        case "Meter": return (value / kmFoot) * kmm;
                        case "Inch": return (value / kmFoot) * kmInches;
                    }; break;
                case "Inch":
                    switch (unit2)
                    {
                        case "Kilometer": return (value / kmInches);
                        case "Centimeter": return (value / kmInches) * kmcm;
                        case "Milimeter": return (value / kmInches) * kmmm;
                        case "Mile": return (value / kmInches) * kmMiles;
                        case "Yard": return (value / kmInches) * kmYard;
                        case "Foot": return (value / kmInches) * kmFoot;
                        case "Meter": return (value / kmInches) * kmm;
                    }; break;

                //mass converters
                case "Kilogram":
                    switch (unit2)
                    {
                        case "Gram": return value * kgg;
                        case "Stone": return (value) * kgStone;
                        case "Pound": return (value) * kgPounds;
                        case "Ounce": return (value) * kgOunce;
                    }; break; 
                
                case "Gram":
                    switch (unit2)
                    {
                        case "Kilogram": return (value / kgg);
                        case "Stone": return (value / kgg) * kgStone;
                        case "Pound": return (value / kgg) * kgPounds;
                        case "Ounce": return (value / kgg) * kgOunce;
                    }; break;

                case "Stone":
                    switch (unit2)
                    {
                        case "Gram": return (value / kgStone)*kgg;
                        case "Kilogram": return (value / kgStone);
                        case "Pound": return (value / kgStone) * kgPounds;
                        case "Ounce": return (value / kgStone) * kgOunce;
                    }; break;

                case "Pound":
                    switch (unit2)
                    {
                        case "Gram": return (value / kgPounds)*kgg;
                        case "Stone": return (value / kgPounds) * kgStone;
                        case "Kilogram": return (value / kgPounds);
                        case "Ounce": return (value / kgPounds) * kgOunce;
                    }; break;

                     case "Ounce":
                    switch (unit2)
                    {
                        case "Gram": return (value / kgOunce)*kgg;
                        case "Stone": return (value / kgOunce) * kgStone;
                        case "Pound": return (value / kgOunce) * kgPounds;
                        case "Kilogram": return (value / kgOunce);
                    }; break;


                  //temperature converter
                case "Celcius":
                    switch (unit2)
                    {
                        case "Fahrenheit": return cF;
                        case "Kelvin": return cK;
                    };break;

                     case "Fahrenheit":
                    switch (unit2)
                    {
                        case "Celcius": return fC;
                        case "Kelvin": return fC + 273.15;
                    };break;

                     case "Kelvin":
                    switch (unit2)
                    {
                        case "Fahrenheit": return (fC * 9 / 5) + 32;
                        case "Celcius": return kC;
                    };break;
            }

            return 0;
        }



    }
}
