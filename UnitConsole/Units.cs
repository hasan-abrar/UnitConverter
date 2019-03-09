using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConsole
{
    abstract public class Units
    {
        double unitValue { get; set; }
        public abstract double ConvertUnit(double unitVal, string unitFromType, string unitToType);
    }

    public class Temperature : Units
    {

        public override double ConvertUnit(double unitVal, string unitFromType, string unitToType)
        {
            
            var dicTemp = new Dictionary<string, Delegate>();
                                    
            dicTemp.Add("fahrenheitTocelsius", new Func<double, double>(FahrenheitToCelsius));
            dicTemp.Add("celsiusTofahrenheit", new Func<double, double>(CelsiusToFahrenheit));
            dicTemp.Add("kelvinTofahrenheit", new Func<double, double>(KelvinToFahrenheit));
            dicTemp.Add("fahrenheitTokelvin", new Func<double, double>(FahrenheitToKelvin));
            dicTemp.Add("kelvinTocelsius", new Func<double, double>(KelvinToCelsius));
            dicTemp.Add("celsiusTokelvin", new Func<double, double>(CelsiusToKelvin));

            
            string keyValue = unitFromType + "To" + unitToType;
            var results = dicTemp[keyValue].DynamicInvoke(unitVal);
            return double.Parse(results.ToString());
            
        }

        public static double FahrenheitToCelsius(double unitVal)
        {
            return (unitVal - 32) * 5 / 9;
        }
        public static double CelsiusToFahrenheit(double unitVal)
        {
            return (unitVal * 9 / 5) + 32;
        }
        public static double KelvinToFahrenheit(double unitVal)
        {
            return (unitVal - 273.15) * 9 / 5 + 32;
        }
        public static double FahrenheitToKelvin(double unitVal)
        {
            return (unitVal - 32) * 5 / 9 + 273.15;
        }
        public static double KelvinToCelsius(double unitVal)
        {
            return unitVal - 273.15;
        }
        public static double CelsiusToKelvin(double unitVal)
        {
            return unitVal + 273.15;
        }

    }
    public class Volume : Units
    {
        public override double ConvertUnit(double unitVal, string unitFromType, string unitToType)
        {
            
            var dicTemp = new Dictionary<string, Delegate>();

            dicTemp.Add("litreTomillilitre", new Func<double, double>(LitreToMillilitre));
            dicTemp.Add("milliLitreTolitre", new Func<double, double>(MilliLitreToLitre));
            dicTemp.Add("usgalTolitre", new Func<double, double>(USGalToLitre));
            dicTemp.Add("litreTousgal", new Func<double, double>(LitreToUSGal));
            dicTemp.Add("usgalTomillilitre", new Func<double, double>(USGalToMillilitre));
            dicTemp.Add("millilitreTousgal", new Func<double, double>(MillilitreToUSGal));


            string keyValue = unitFromType + "To" + unitToType;
            var results = dicTemp[keyValue].DynamicInvoke(unitVal);
            return double.Parse(results.ToString());

        }

        public double LitreToMillilitre(double unitVal)
        {
            return unitVal * 1000;
        }
        public double MilliLitreToLitre(double unitVal)
        {
            return (unitVal / 1000);
        }
        public double USGalToLitre(double unitVal)
        {
            return unitVal * 3.785;
        }
        public double LitreToUSGal(double unitVal)
        {
            return unitVal / 3.785;
        }
        public double USGalToMillilitre(double unitVal)
        {
            return unitVal * 3785.412;
        }
        public double MillilitreToUSGal(double unitVal)
        {
            return unitVal / 3785.412;
        }

    }
}
