namespace Doonk.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNull(this string str)
            => str == null;
        
        public static bool IsNotNull(this string str)
            => !str.IsNull();

        public static bool IsEmpty(this string str)
            => str.Length == 0;

        public static bool IsNotEmpty(this string str)
            => !str.IsEmpty();

        public static bool IsNullOrEmpty(this string str)
            => string.IsNullOrEmpty(str);

        public static bool IsNullOrWhiteSpace(this string str)
            => string.IsNullOrWhiteSpace(str);
    }
}