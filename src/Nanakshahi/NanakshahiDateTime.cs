using System;
using Nanakshahi.Extensions;
using Nanakshahi.Helpers;
using Nanakshahi.Nanakshahi;

namespace Nanakshahi
{
    public struct NanakshahiDateTime
    {
        public int Year => NsDateTime.Year;
        public NsMonth Month => NsHelper.MonthToNsMonth(NsDateTime.Month - 1);
        public int Day => NsDateTime.Day;
        public int Hour => NsDateTime.Hour;
        public int Minute => NsDateTime.Minute;
        public int Second => NsDateTime.Second;
        public double Millisecond => NsDateTime.Millisecond;
        public NsDayOfWeek DayOfWeek => NsHelper.DayOfWeekToNsDayOfWeek(NsCalendar.GetDayOfWeek(NsDateTime));
        public int DayOfYear => NsCalendar.GetDayOfYear(NsDateTime);
        public static NanakshahiDateTime Now => DateTime.Now.ToNanakshahiDateTime();
        public static NanakshahiDateTime Today => DateTime.Today.ToNanakshahiDateTime();
        private static NanakshahiCalendar NsCalendar => new();
        private static NsDateTime NsDateTime { get; set; }

        public NanakshahiDateTime(int year = 1, int month = 1, int day = 1) =>
            NsDateTime = new NsDateTime(year, month, day, 0, 0, 0, 0);

        public NanakshahiDateTime(int year, Enums.NsMonth nsMonth, int day) =>
            NsDateTime = new NsDateTime(year, (int) nsMonth, day, 0, 0, 0, 0);

        public NanakshahiDateTime(int year, int month, int day, int hour, int minute, int second) =>
            NsDateTime = new NsDateTime(year, month, day, hour, minute, second, 0);

        public NanakshahiDateTime(int year, Enums.NsMonth nsMonth, int day, int hour, int minute, int second) =>
            NsDateTime = new NsDateTime(year, (int) nsMonth, day, hour, minute, second, 0);

        public NanakshahiDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) =>
            NsDateTime = new NsDateTime(year, month, day, hour, minute, second, millisecond);

        public NanakshahiDateTime(int year, Enums.NsMonth nsMonth, int day, int hour, int minute, int second,
            int millisecond) =>
            NsDateTime = new NsDateTime(year, (int) nsMonth, day, hour, minute, second, millisecond);

        public DateTime ToGregorianDateTime() =>
            NsCalendar.ToGregorianDateTime(NsDateTime);

        public static int DaysInMonth(int year, int month) =>
            NsCalendar.GetDaysInMonth(year, month);

        public static int DaysInMonth(int year, Enums.NsMonth nsMonth) =>
            NsCalendar.GetDaysInMonth(year, (int) nsMonth);

        public override string ToString() =>
            $"{Year:0000}/{Month.MonthNumber:00}/{Day:00} {Hour:00}:{Minute:00}:{Second:00}";
    }
}