using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment2_Section2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherService" in both code and config file together.
    public class WeatherService : IWeatherService
    {
        public double CelciusToFarenheit(double value)
        {
            return (value * (1.8)) + 32;
        }

        public double FarenheitToCelcius(double value)
        {
            return (value - 32) * (0.56);
        }
    }
}
