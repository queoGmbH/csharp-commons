using System;
using System.Globalization;
using System.Threading;

using NUnit.Framework;

using Queo.Commons.Utils;

namespace Queo.Commons.Tests.Utils
{
    [TestFixture]
    public class DateTimeUtilsTest
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
            DateTime actualFirstDayOfWeek = DateTimeUtils.GetFirstDayOfWeek(dayInWeek, specificCulture);

            // Culture wieder zurückstellen!
            // then:
            Assert.AreEqual(expectedFirstDayInWeek, actualFirstDayOfWeek);
        }

        [Test]
        public void TestGetFirstDayOfWeek()
        {
            // Given: 
            var dayInWeek = new DateTime(2014, 12, 10);
            var expectedFirstDayOfWeek = new DateTime(2014, 12, 8);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-de");
            // when:
            DateTime actualFirstDayOfWeek = DateTimeUtils.GetFirstDayOfWeek(dayInWeek);
            // then:
            Assert.AreEqual(expectedFirstDayOfWeek, actualFirstDayOfWeek);
        }

        [Test]
        public void TestGetFirstDayOfWeekFromFirstDayOfWeek()
        {
            // given:
            var expectedFirstDayOfWeek = new DateTime(2014, 12, 8);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-de");
            // when:
            DateTime actualFirstDayOfWeek = DateTimeUtils.GetFirstDayOfWeek(expectedFirstDayOfWeek);
            // then:
            Assert.AreEqual(expectedFirstDayOfWeek, actualFirstDayOfWeek);
        }

        [Test]
        public void TestMaxFirstDay()
        {
            // given:
            var firstDay = new DateTime(2012, 12, 12);
            var secondDay = new DateTime(2012, 12, 11);
            // when:
            DateTime actualMaxDateTime = DateTimeUtils.Max(firstDay, secondDay);
            // then:
            Assert.AreEqual(firstDay, actualMaxDateTime);
        }

        [Test]
        public void TestMaxSameDates()
        {
            // given:
            var firstDay = new DateTime(2014, 11, 11);
            var secondDay = new DateTime(2014, 11, 11);
            // when
            DateTime actualMaxDate = DateTimeUtils.Max(firstDay, secondDay);
            // then:
            Assert.AreEqual(firstDay, actualMaxDate);
        }

        [Test]
        public void TestMaxSecondDay()
        {
            // given: 
            var firstDay = new DateTime(2014, 12, 5);
            var secondDay = new DateTime(2014, 12, 11);
            // when:
            DateTime actualMaxDate = DateTimeUtils.Max(firstDay, secondDay);
            // then:
            Assert.AreEqual(secondDay, actualMaxDate);
        }

        [Test]
        public void TestMinFirstDay()
        {
            // given:
            var firstDay = new DateTime(2013, 11, 11);
            var secondDay = new DateTime(2014, 11, 11);
            // when:
            DateTime actualMinDay = DateTimeUtils.Min(firstDay, secondDay);
            // then:
            Assert.AreEqual(firstDay, actualMinDay);
        }

        [Test]
        public void TestMinSecondDay()
        {
            // given:
            var firstDay = new DateTime(2014, 10, 13);
            var secondDay = new DateTime(2014, 10, 12);
            // when:
            DateTime actualMinDay = DateTimeUtils.Min(firstDay, secondDay);
            // then:
            Assert.AreEqual(secondDay, actualMinDay);
        }
    }
}