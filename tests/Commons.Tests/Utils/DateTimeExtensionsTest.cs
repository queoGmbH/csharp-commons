using System;
using System.Globalization;
using System.Threading;

using NUnit.Framework;
using NUnit.Framework.Legacy;

using Queo.Commons.Utils;

namespace Queo.Commons.Tests.Utils
{
    /// <summary>
    ///     Die Test prüfen nur, ob die Erweiterungsmethoden allgemein funktional sind.
    ///     Die eigentliche Funktionalität wird in DateTimeUtils getestet.
    ///     Methoden die ihre Funktionalität nicht über DateTimeUtils beziehen, sind ausführliche Tests zu schreiben.
    /// </summary>
    [TestFixture]
    public class DateTimeExtensionsTest
    {
        [Test]
        public void TestFirstDayOfWeekWithCultureEnUs()
        {
            // given:
            CultureInfo specificCulture = CultureInfo.CreateSpecificCulture("en-US");
            var dayInWeek = new DateTime(2014, 12, 10);
            // In en-US beginnt die Woche mit dem Sonntag
            var expectedFirstDayInWeek = new DateTime(2014, 12, 7);
            // when:
            DateTime actualFirstDayOfWeek = dayInWeek.GetFirstDayOfWeek(specificCulture);

            // then:
            ClassicAssert.AreEqual(expectedFirstDayInWeek, actualFirstDayOfWeek);
        }

        [Test]
        public void TestGetFirstDayOfWeek()
        {
            // Given: 
            var dayInWeek = new DateTime(2014, 12, 10);
            var expectedFirstDayOfWeek = new DateTime(2014, 12, 8);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-de");
            // when:
            DateTime actualFirstDayOfWeek = dayInWeek.GetFirstDayOfWeek();
            // then:
            ClassicAssert.AreEqual(expectedFirstDayOfWeek, actualFirstDayOfWeek);
        }
    }
}
