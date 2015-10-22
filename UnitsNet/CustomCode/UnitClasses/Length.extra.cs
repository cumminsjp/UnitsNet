using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    /// Extension to the generated Length struct.
    /// Makes it easier to work with Feet/Inches combinations, which are customarily used in the US and UK
    /// to express body height. For example, someone is 5 feet 3 inches tall.
    /// </summary>
    public partial struct Length
    {
        private const double FeetToInches = 12;

        /// <summary>
        /// Converts the length to a customary feet/inches combination.
        /// </summary>
        public FeetInches FeetInches
        {
            get
            {
                double totalInches = Inches;
                double wholeFeet = Math.Floor(totalInches / FeetToInches);
                double inches = totalInches % FeetToInches;

                return new FeetInches(wholeFeet, inches);
            }
        }

        /// <summary>
        ///     Get length from combination of feet and inches.
        /// </summary>
        public static Length FromFeetInches(double feet, double inches)
        {
            return FromInches((FeetToInches * feet) + inches);
        }

        /// <summary>
        /// Gets length from 2 lat/long coordinates
        /// </summary>
        /// <param name="latitude1">The latitude1.</param>
        /// <param name="longitude1">The longitude1.</param>
        /// <param name="latitude2">The latitude2.</param>
        /// <param name="longitude2">The longitude2.</param>
        /// <returns></returns>
        public static Length FromLatitudeLongitude(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            var distance = HaversineDistance(latitude1, longitude1, latitude2, longitude2);

            return FromMeters(distance);
        }

        /// <summary>
        /// Returns the distance in meters of any two latitude / longitude points
        /// </summary>
        /// <param name="latitude1">The latitude1 (y)</param>
        /// <param name="longitude1">The longitude1 (x)</param>
        /// <param name="latitude2">The latitude2 (y)</param>
        /// <param name="longitude2">The longitude2 (x)</param>
        /// <returns>
        /// Distance in meters
        /// </returns>
        private static double HaversineDistance(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            // ReSharper disable once InconsistentNaming
            const double EARTH_RADIUS_KM = 6371;

            var lat = ToRadians((latitude2 - latitude1));
            var lng = ToRadians((longitude2 - longitude1));

            var h1 = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
                     Math.Cos(ToRadians(latitude1)) * Math.Cos(ToRadians(latitude2)) *
                     Math.Sin(lng / 2) * Math.Sin(lng / 2);

            var h2 = 2 * Math.Asin(Math.Min(1, Math.Sqrt(h1)));

            return (EARTH_RADIUS_KM * h2) * 1000;
        }


        /// <summary>
        /// Convert to Radians 
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns></returns>
        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }

    public class FeetInches
    {
        public double Feet { get; private set; }
        public double Inches { get; private set; }

        public FeetInches(double feet, double inches)
        {
            Feet = feet;
            Inches = inches;
        }

        public string ToString(IFormatProvider cultureInfo = null)
        {
            // Note that it isn't customary to use fractions - one wouldn't say "I am 5 feet and 4.5 inches".
            // So inches are rounded when converting from base units to feet/inches.

            var unitSystem = UnitSystem.GetCached(cultureInfo);
            string footUnit = unitSystem.GetDefaultAbbreviation(LengthUnit.Foot);
            string inchUnit = unitSystem.GetDefaultAbbreviation(LengthUnit.Inch);

            return string.Format((cultureInfo == null) ? CultureInfo.CurrentCulture : cultureInfo, "{0:n0} {1} {2:n0} {3}", Feet, footUnit, Math.Round(Inches), inchUnit);
        }
    }
}
