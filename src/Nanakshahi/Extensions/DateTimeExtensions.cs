using System;
using Nanakshahi.Helpers;

namespace Nanakshahi.Extensions
{
    public static class DateTimeExtensions
    {
        public static NanakshahiDateTime ToNanakshahiDateTime(this DateTime gregorianDate)
        {
            if (gregorianDate.Year < 1469 && gregorianDate.Month < 3 && gregorianDate.Day < 14)
            {
                throw new ArgumentOutOfRangeException(nameof(gregorianDate), gregorianDate,
                    "Enter a date of 1469/3/14 or larger.");
            }

            var holaMohalla = new DateTime(gregorianDate.Year, 3, 14);

            var nsYear = gregorianDate >= holaMohalla
                ? gregorianDate.Year - 1468
                : gregorianDate.Year - 1469;

            var nsMonth = NsHelper.MonthToNsMonth((gregorianDate.Month + 8) % 12);
            var nsNextMonth = NsHelper.MonthToNsMonth(nsMonth.MonthNumber % 12);

            int nsDay;

            if (gregorianDate.Day >= nsNextMonth.Offset)
            {
                nsMonth = nsNextMonth;
                nsDay = gregorianDate.Day - nsNextMonth.Offset + 1;
            }
            else
            {
                var firstOfNsMonth = new DateTime(
                    gregorianDate.Year,
                    gregorianDate.Month - 1,
                    nsMonth.Offset
                );

                nsDay = (int) (gregorianDate.ToUniversalTime() - firstOfNsMonth.ToUniversalTime()).TotalDays + 1;
            }

            return new NanakshahiDateTime(nsYear, nsMonth.MonthNumber, nsDay, gregorianDate.Hour, gregorianDate.Minute,
                gregorianDate.Second, gregorianDate.Millisecond);
        }
    }
}