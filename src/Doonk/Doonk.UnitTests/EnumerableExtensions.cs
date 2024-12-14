using Doonk.Extensions;

namespace Doonk.UnitTests;

public class EnumerableExtensions
{
    public static IEnumerable<object[]> List_IsNullOrEmpty_Data => new List<object[]>
    {
        new object[] {null, true},
        new object[] {new List<string>(), true},
        new object[] {new List<string> {"", "ds"}, false},
    };
    
    [Theory]
    [MemberData(nameof(List_IsNullOrEmpty_Data), parameters: 2)]
    public void List_IsNullOrEmpty(List<string> list, bool expected)
    {
        var result = list.IsNullOrEmpty();
        Assert.Equal(result, expected);
    }
    
    [Theory]
    [MemberData(nameof(List_IsNullOrEmpty_Data), parameters: 2)]
    public void Enumerable_IsNullOrEmpty(IEnumerable<string> list, bool expected)
    {
        var result = list.IsNullOrEmpty();
        Assert.Equal(result, expected);
    }
    
    public static IEnumerable<object[]> List_IsEmpty_Data => new List<object[]>
    {
        new object[] {new List<string>(), true},
        new object[] {new List<string> {"", "ds"}, false},
    };
    
    [Theory]
    [MemberData(nameof(List_IsEmpty_Data), parameters: 2)]
    public void List_IsEmpty(List<string> list, bool expected)
    {
        var result = list.IsEmpty();
        Assert.Equal(result, expected);
    }
    
    [Theory]
    [MemberData(nameof(List_IsEmpty_Data), parameters: 2)]
    public void Enumerable_IsEmpty(IEnumerable<string> list, bool expected)
    {
        var result = list.IsEmpty();
        Assert.Equal(result, expected);
    }

    [Fact]
    public void List_AddElements_DuckTypeAdd()
    {
        var list = new List<string> {"a", "b", "c"};
        var result = new List<string>
        {
            "k", list, "m"
        };
        
        Assert.Equal(result.Count, 5);
        Assert.Equal(result, new List<string> {"k", "a", "b", "c", "m"});
    }

    [Fact]
    public void List_AddElements_Add()
    {
        var list = new List<string> {"a", "b", "c"};
        var result = new List<string> { "k", "m" };
        result.Add(list);
        
        Assert.Equal(result.Count, 5);
        Assert.Equal(result, new List<string> {"k", "m", "a", "b", "c"});
    }

    [Fact]
    public void List_AddElements_AddRange()
    {
        IList<string> list = new List<string> {"a", "b", "c"};
        IList<string> result = new List<string> { "k", "m" };
        result.AddRange(list);
        
        Assert.Equal(result.Count, 5);
        Assert.Equal(result, new List<string> {"k", "m", "a", "b", "c"});
    }

    [Fact]
    public void Dictionary_AddElements_AddRange()
    {
        var dict = new Dictionary<string, string>
        {
            { "a", "b" },
        };
        var result = new Dictionary<string, string>
        {
            { "k", "m" },
        };
        
        result.AddRange(dict);
        
        Assert.Equal(result.Count, 2);
        Assert.Equal(result, new Dictionary<string, string> {{ "a", "b" },{ "k", "m" }});
    }

    [Fact]
    public void Dictionary_AddElements_KVP_AddRange()
    {
        var dict = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("a", "b"),
        };
        var result = new Dictionary<string, string>
        {
            { "k", "m" },
        };
        
        result.AddRange(dict);
        
        Assert.Equal(result.Count, 2);
        Assert.Equal(result, new Dictionary<string, string> {{ "a", "b" },{ "k", "m" }});
    }
}