using Doonk.Extensions;

namespace Doonk.UnitTests;

public class StringExtensions
{
    [Theory]
    [InlineData(null, true)]
    [InlineData("", false)]
    [InlineData("sdfsdf", false)]
    [InlineData("     ", false)]
    public void String_IsNull(string str, bool expected)
    {
        var result = str.IsNull();
        Assert.Equal(result, expected);
    }
    
    [Theory]
    [InlineData(null, false)]
    [InlineData("", true)]
    [InlineData("sdfsdf", true)]
    [InlineData("     ", true)]
    public void String_IsNotNull(string str, bool expected)
    {
        var result = str.IsNotNull();
        Assert.Equal(result, expected);
    }
    
    [Theory]
    [InlineData("", true)]
    [InlineData("sdfsdf", false)]
    [InlineData("     ", false)]
    public void String_IsEmpty(string str, bool expected)
    {
        var result = str.IsEmpty();
        Assert.Equal(result, expected);
    }
    
    [Theory]
    [InlineData("", false)]
    [InlineData("sdfsdf", true)]
    [InlineData("     ", true)]
    public void String_IsNotEmpty(string str, bool expected)
    {
        var result = str.IsNotEmpty();
        Assert.Equal(result, expected);
    }
    
    [Theory]
    [InlineData(null, true)]
    [InlineData("", true)]
    [InlineData("sdfsdf", false)]
    [InlineData("     ", false)]
    public void String_IsNullOrEmpty(string str, bool expected)
    {
        var result = str.IsNullOrEmpty();
        Assert.Equal(result, expected);
    }
    
    [Theory]
    [InlineData(null, true)]
    [InlineData("", true)]
    [InlineData("sdfsdf", false)]
    [InlineData("     ", true)]
    public void String_IsNullOrWhiteSpace(string str, bool expected)
    {
        var result = str.IsNullOrWhiteSpace();
        Assert.Equal(result, expected);
    }
}