

namespace StringUtilities;

public static class StringUtils
{
    public static string ReverseString(string text)
    {
        if (text == null) return null;
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
        // return text;
    }

    public static int CountVowels(string text)
    {
        if (string.IsNullOrEmpty(text)) return 0;
        string vowels = "aeiouAEIOU";
        return text.Count(c => vowels.Contains(c));
    }

    public static bool IsPalindrome(string text)
    {
        if (text == null) return false;
        string cleaned = text.ToLower().Replace(" ", "");
        string reversed = new string(cleaned.Reverse().ToArray());
        return cleaned == reversed;
    }
}