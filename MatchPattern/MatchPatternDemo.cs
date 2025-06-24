namespace DotNetLearn.MatchPattern;
[TestFixture]
public class MatchPatternDemo
{
    [Test]
    public void Test01()
    {
        Console.WriteLine($"Or(true,false)结果是:{Or(true, false)}");
    }

    private static bool Or(bool a, bool b) =>
        (a, b) switch
        {
            (_, true) => true,
            (true,_)=> true,
            (_, _) => false,
        };
}