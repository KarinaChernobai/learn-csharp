using ConsoleApppLearn;
using Xunit.Sdk;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void ReverseStringTest()
    {
        var str = "Karolina";
        var expected = "aniloraK";
        var actual = str.ReverseStr();
        Assert.Equal(expected, actual);
    }

    [Theory()]
    [InlineData("", "")]
    [InlineData("X", "X")]
    [InlineData("XY", "YX")]
    public void ReverseStringTest2(string expected, string original)
    {
        var actual = original.ReverseStr();
        Assert.Equal(expected, actual);
    }
}