namespace PenUnitTesting.Data
{
    public class TestData
    {
        public static object[] DifferentColors =
        {
            new object[] { "" },
            new object[] { "red" },
            new object[] { " white" }
        };

        public static object[] DifferentInkCounterAndWordValues =
        {
            new object[] { 3, "red", "red" },
            new object[] { 0, "red", "" },
            new object[] { -3, "red", "" }
        };
        
        public static object[] DifferentWords =
        {
            new object[] { "", "" },
            new object[] { " ", " " },
            new object[] { "123456789", "123456789" },
            new object[] { "abcdefghij", "abcdefghij" },
            new object[] { " abcdefghij", " abcdefghij" },
            new object[] { "123456789000", "1234567890" }
        };

        public static object[] DifferentInkCounterAndSizeLetters =
        {
            new object[] {1, 1, "r", "r"},
            new object[] {3, 0, "red", ""},
            new object[] {1, 0.1, "red", "red"},
            new object[] {1, -2, "red", ""}
        };
    }
}