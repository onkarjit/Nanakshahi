namespace Nanakshahi.Nanakshahi
{
    internal static class NsMonths
    {
        public static NsMonth Chet { get; }
        public static NsMonth Vaisakh { get; }
        public static NsMonth Jeth { get; }
        public static NsMonth Harh { get; }
        public static NsMonth Sawan { get; }
        public static NsMonth Bhadon { get; }
        public static NsMonth Assu { get; }
        public static NsMonth Katak { get; }
        public static NsMonth Maghar { get; }
        public static NsMonth Poh { get; }
        public static NsMonth Magh { get; }
        public static NsMonth Phagun { get; }

        static NsMonths()
        {
            Chet = new NsMonth(1, 14, "ਚੇਤ", "Chet");
            Vaisakh = new NsMonth(2, 14, "ਵੈਸਾਖ", "Vaisakh");
            Jeth = new NsMonth(3, 15, "ਜੇਠ", "Jeth");
            Harh = new NsMonth(4, 15, "ਹਾੜ", "Harh");
            Sawan = new NsMonth(5, 16, "ਸਾਵਣ", "Sawan");
            Bhadon = new NsMonth(6, 16, "ਭਾਦੋਂ", "Bhadon");
            Assu = new NsMonth(7, 15, "ਅੱਸੂ", "Assu");
            Katak = new NsMonth(8, 15, "ਕੱਤਕ", "Katak");
            Maghar = new NsMonth(9, 14, "ਮੱਘਰ", "Maghar");
            Poh = new NsMonth(10, 14, "ਪੋਹ", "Poh");
            Magh = new NsMonth(11, 13, "ਮਾਘ", "Magh");
            Phagun = new NsMonth(12, 12, "ਫੱਗਣ", "Phagun");
        }
    }

    public readonly struct NsMonth
    {
        public int MonthNumber { get; }
        public int Offset { get; }
        public string GurmukhiName { get; }
        public string TransliterationName { get; }

        public NsMonth(int monthNumber, int offset, string gurmukhiName, string transliterationName)
        {
            MonthNumber = monthNumber;
            Offset = offset;
            GurmukhiName = gurmukhiName;
            TransliterationName = transliterationName;
        }
        
        public override string ToString() =>
            MonthNumber.ToString();
    }
}