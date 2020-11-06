namespace EffectiveTables.Application.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string @this) =>
            string.IsNullOrEmpty(@this) || string.IsNullOrWhiteSpace(@this);
    }
}