public static class StringExtensions
{
    extension(string value)
    {
        public bool IsNullOrEmpty() => string.IsNullOrEmpty(value);
        public string Truncate(int max) => string.IsNullOrEmpty(value) || value.Length <= max ? value : value[..max];
        public static bool IsAscii(char c) => c <= 0x7F;

        public int WordCount => value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        public bool FiscalNumberIsValid() => value.Length == 9;        
    }
}