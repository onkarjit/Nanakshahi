using System;
using Nanakshahi.Helpers;

namespace Nanakshahi.Nanakshahi
{
    internal struct NsDateTime
    {
        public int Year { get; }
        public int Month { get; }
        public int Day { get; }
        public int Hour { get; }
        public int Minute { get; }
        public int Second { get; }
        public double Millisecond { get; }

        public NsDateTime(int year, int month, int day, int hour, int minute, int second, double millisecond)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException(nameof(year), year,
                    "Enter a year between (1-9999).");
            }

            var daysOfMonth = NanakshahiDateTime.DaysInMonth(year, month);
            var nanakshahiMonth = NsHelper.MonthToNsMonth(month - 1);

            if (day < 1 || day > daysOfMonth)
            {
                throw new ArgumentOutOfRangeException(nameof(day), day,
                    $"Enter a valid day. The month {nanakshahiMonth.TransliterationName} in year {year} has (1-{daysOfMonth}) days.");
            }
            
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(hour), hour,
                    "Enter an hour between (0-23).");
            }
            
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(minute), minute,
                    "Enter a minute between (0-59).");
            }
            
            if (second < 0 || second > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(second), second,
                    "Enter a second between (0-59).");
            }
            
            if (millisecond < 0 || millisecond > 999)
            {
                throw new ArgumentOutOfRangeException(nameof(millisecond), millisecond,
                    "Enter a second between (0-999).");
            }
            
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
            Millisecond = millisecond;
        }
    }
}