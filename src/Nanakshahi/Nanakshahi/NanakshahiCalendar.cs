using System;
using Nanakshahi.Helpers;

namespace Nanakshahi.Nanakshahi
{
    internal class NanakshahiCalendar
    {
        private static readonly DateTime HolaMohalla = new(1969, 3, 14);

        public DateTime MinSupportedDateTime => HolaMohalla;

        public DateTime MaxSupportedDateTime => DateTime.MaxValue;

        public int[] Eras { get; } = { 1, 2, 3, 4 };
        
        public int GetDayOfWeek(NsDateTime nsDateTime) =>
            (int) ToGregorianDateTime(nsDateTime).DayOfWeek;
        
        public int GetDayOfYear(NsDateTime nsDateTime) =>
            31 * (nsDateTime.Month - 1) - Math.Max(0, nsDateTime.Month - 6) + nsDateTime.Day;
        
        public int GetDaysInMonth(int year, int month)
        {
            return month switch
            {
                var n when (n > 0 && n < 6) => 31,
                var n when (n > 5 && n < 12) => 30,
                var n when (n == 12) => DateTime.IsLeapYear(year) ? 31 : 30,
                _ => throw new ArgumentOutOfRangeException(nameof(month),
                    "Enter a valid Nanakshahi month (1-12). Or make use of the NanakshahiMonth Enum.")
            };
        }

        public int GetDaysInYear(int year)
            => IsLeapYear(year) ? 366 : 365;
        
        public int GetEra(NsDateTime nsDateTime)
        {
            throw new NotImplementedException();
        }

        public int GetMonthsInYear() => 12;
        
        public int GetYear(NsDateTime nsDateTime) =>
            nsDateTime.Year;

        public bool IsLeapDay(int year, int month, int day) =>
            IsLeapYear(year) && month == 12 && day == 31;
        
        public bool IsLeapMonth(int year, int month) =>
            IsLeapYear(year) && month == 12;
        
        public bool IsLeapYear(int year) =>
            DateTime.IsLeapYear(year);
        
        public DateTime ToGregorianDateTime(NsDateTime dateTime)
        {
            var nsMonthNumber = dateTime.Month;

            var gregorianYear = nsMonthNumber < 11 ? dateTime.Year + 1468 : dateTime.Year + 1469;

            var gregorianMonth = nsMonthNumber < 11 ? nsMonthNumber + 1 : nsMonthNumber - 11;

            var nsMonth = NsHelper.MonthToNsMonth(dateTime.Month - 1);

            var gregorianDays = nsMonth.Offset + (dateTime.Day - 2);
 
            return new DateTime()
                .AddYears(gregorianYear - 1)
                .AddMonths(gregorianMonth)
                .AddDays(gregorianDays)
                .AddHours(dateTime.Hour)
                .AddMinutes(dateTime.Minute)
                .AddSeconds(dateTime.Second)
                .AddMilliseconds(dateTime.Millisecond);
        }
    }
}