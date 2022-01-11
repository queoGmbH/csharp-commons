using System;
using System.Globalization;

namespace Queo.Commons.Utils
{
    /// <summary>
    ///     Klasse mit Hilfsmethoden für Datumsberechnungen.
    /// </summary>
    public static class DateTimeUtils
    {
        /// <summary>
        ///     Liefert ein <code>DateTime</code>, welches den ersten Tag der Woche repräsentiert,
        ///     in dem sich das Datum befindet.
        /// </summary>
        /// <param name="date">Ein Datum </param>
        /// <returns>
        ///     Das Datum des ersten Tags der Woche in dem sich das
        ///     <param name="date">Datum</param>
        ///     befindet.
        /// </returns>
        public static DateTime GetFirstDayOfWeek(DateTime date)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            DateTime firstDayOfWeek = GetFirstDayOfWeek(date, currentCulture);

            return firstDayOfWeek;
        }

        /// <summary>
        ///     Liefert ein <code>DateTime</code>, welches den ersten Tag der Woche repräsentiert,
        ///     in dem sich das Datum befindet.
        /// </summary>
        /// <param name="date">Ein Datum</param>
        /// <param name="cultureInfo"> Die CultureInfo die zur Berechnung verwendet wird.</param>
        /// <returns>Das Datum des ersten Tags in der Woche.</returns>
        public static DateTime GetFirstDayOfWeek(DateTime date, CultureInfo cultureInfo)
        {
            DateTime tmp = date;
            DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            while (tmp.DayOfWeek != firstDayOfWeek)
            {
                tmp = tmp.AddDays(-1);
            }

            return tmp;
        }

        /// <summary>
        ///     Liefert das größere von zwei DateTime-Objekten zurück.
        ///     Das größere Datum ist das spätere Datum.
        /// </summary>
        /// <param name="firstDateTime"> Das erste von zwei zu vergleichenden Datumswerten. </param>
        /// <param name="secondDateTime"> Das zweite von zwei zu vergleichenden Datumswerten. </param>
        /// <returns> Das größere (spätere) DateTime Objekt bzw. das erste, wenn die Werte gleich sind..</returns>
        public static DateTime Max(DateTime firstDateTime, DateTime secondDateTime)
        {
            if (DateTime.Compare(firstDateTime, secondDateTime) >= 0)
            {
                return firstDateTime;
            }

            return secondDateTime;
        }

        /// <summary>
        ///     Liefert das kleinere von zwei DateTime-Objekten zurück.
        ///     Das kleinere Datum ist das frühere Datum.
        /// </summary>
        /// <param name="firstDateTime"> Das erste von zwei zu vergleichenden Datumswerten. </param>
        /// <param name="secondDateTime"> Das zweite von zwei zu vergleichenden Datumswerten. </param>
        /// <returns> Das kleinere DateTime Objekt bzw. das erste, wenn die Werte gleich sind.</returns>
        public static DateTime Min(DateTime firstDateTime, DateTime secondDateTime)
        {
            if (DateTime.Compare(firstDateTime, secondDateTime) <= 0)
            {
                return firstDateTime;
            }

            return secondDateTime;
        }
    }
}