using System;
using Nanakshahi.Nanakshahi;

namespace Nanakshahi.Helpers
{
    internal class NsHelper
    {
        internal static NsDayOfWeek DayOfWeekToNsDayOfWeek(int dayOfWeek)
        {
            return dayOfWeek switch
            {
                0 => NsDaysOfWeek.Aitvaar,
                1 => NsDaysOfWeek.Somvaar,
                2 => NsDaysOfWeek.Mangalvaar,
                3 => NsDaysOfWeek.Budhvaar,
                4 => NsDaysOfWeek.Veervaar,
                5 => NsDaysOfWeek.Shukarvaar,
                6 => NsDaysOfWeek.Shanivaar,
                _ => throw new ArgumentOutOfRangeException(nameof(dayOfWeek), dayOfWeek,
                    "Failed to find the day of week for given dayOfWeek.")
            };
        }

        internal static NsMonth MonthToNsMonth(int nsMonth)
        {
            return nsMonth switch
            {
                0 => NsMonths.Chet,
                1 => NsMonths.Vaisakh,
                2 => NsMonths.Jeth,
                3 => NsMonths.Harh,
                4 => NsMonths.Sawan,
                5 => NsMonths.Bhadon,
                6 => NsMonths.Assu,
                7 => NsMonths.Katak,
                8 => NsMonths.Maghar,
                9 => NsMonths.Poh,
                10 => NsMonths.Magh,
                11 => NsMonths.Phagun,
                _ => throw new ArgumentOutOfRangeException(nameof(nsMonth), nsMonth,
                    "Enter a valid Nanakshahi month (1-12). Or make use of the NanakshahiMonth Enum.")
            };
        }
    }
}