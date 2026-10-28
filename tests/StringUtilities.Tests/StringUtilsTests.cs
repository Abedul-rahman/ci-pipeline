

namespace StringUtilities.Tests;

public class StringUtilsTests
{
    [Fact]
    public void ReverseString_ShouldReverseCharacters()
    {
        Assert.Equal("olleh", StringUtils.ReverseString("hello"));
    }

    [Fact]
    public void CountVowels_ShouldCountCorrectly()
    {
        Assert.Equal(3, StringUtils.CountVowels("hello world"));
    }

    [Fact]
    public void IsPalindrome_ShouldReturnTrueForPalindrome()
    {
        Assert.True(StringUtils.IsPalindrome("racecar"));
    }
}