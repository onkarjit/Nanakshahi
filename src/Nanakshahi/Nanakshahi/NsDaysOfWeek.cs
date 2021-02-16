using System;

namespace Nanakshahi.Nanakshahi
{
    public static class NsDaysOfWeek
    {
        public static NsDayOfWeek Aitvaar { get; }
        public static NsDayOfWeek Somvaar { get; }
        public static NsDayOfWeek Mangalvaar { get; }
        public static NsDayOfWeek Budhvaar { get; }
        public static NsDayOfWeek Veervaar { get; }
        public static NsDayOfWeek Shukarvaar { get; }
        public static NsDayOfWeek Shanivaar  { get; }

        static NsDaysOfWeek()
        {
            Aitvaar = new NsDayOfWeek(0, "ਐਤਵਾਰ", "Aitvaar");
            Somvaar = new NsDayOfWeek(1, "ਸੋਮਵਾਰ", "Somvaar");
            Mangalvaar = new NsDayOfWeek(2, "ਮੰਗਲਵਾਰ", "Mangalvaar");
            Budhvaar = new NsDayOfWeek(3, "ਬੁੱਧਵਾਰ", "Budhvaar");
            Veervaar = new NsDayOfWeek(4, "ਵੀਰਵਾਰ", "Veervaar");
            Shukarvaar = new NsDayOfWeek(5, "ਸ਼ੁੱਕਰਵਾਰ", "Shukarvaar");
            Shanivaar = new NsDayOfWeek(6, "ਸ਼ਨੀਵਾਰ", "Shanivaar");
        }
    }

    public struct NsDayOfWeek
    { 
        public int DayNumber { get; }
        public string GurmukhiName { get; }
        public string TransliterationName { get; }
        public string EnglishName { get; }

        public NsDayOfWeek(int dayNumber, string gurmukhiName, string transliterationName)
        {
            DayNumber = dayNumber;
            GurmukhiName = gurmukhiName;
            TransliterationName = transliterationName;
            EnglishName = Enum.GetName(typeof(DayOfWeek),dayNumber - 1);
        }
        public override string ToString() =>
            DayNumber.ToString();
    }
}