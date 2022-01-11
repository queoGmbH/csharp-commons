using System;
using System.Globalization;

namespace Queo.Commons.Utils
{
    /// <summary>
    ///     Allgemeine Erweiterungmethoden für DateTime-Instanzen.
    /// </summary>
    /// <remarks>
    ///     Diese verwenden im Allgemeinen die DateTimeUtils für die Berechnung.
    /// </remarks>
    public static class DateTimeExtensions
    {
        /// <summary>
        ///     Liefert ein <code>DateTime</code>, welches den ersten Tag der Woche repräsentiert,
        ///     in dem sich das Datum befindet.
        /// </summary>
        /// <param name="datetime"> </param>
        /// <returns> </returns>
        public static DateTime GetFirstDayOfWeek(this DateTime datetime)
        {
            DateTime firstDayOfWeek = DateTimeUtils.GetFirstDayOfWeek(datetime);
            return firstDayOfWeek;
        }

        /// <summary>
        /// </summary>
        /// <param name="datetime">Das Datum</param>
        /// <param name="cultureInfo">Die CultureInfo die zur Berechnung verwendet wird.</param>
        /// <returns>Das Datum vom ersten Tag in der Woche.</returns>
        public static DateTime GetFirstDayOfWeek(this DateTime datetime, CultureInfo cultureInfo)
        {
            DateTime firstDayOfWeek = DateTimeUtils.GetFirstDayOfWeek(datetime, cultureInfo);
            return firstDayOfWeek;
        }
    }
}