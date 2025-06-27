using System.Diagnostics.CodeAnalysis;

namespace DotNetLearn.MatchPattern;
[TestFixture]
public class MatchPatternDemo
{
    [Test]
    public void Test01()
    {
        Console.WriteLine($"Or(true,false)结果是:{Or(true, false)}");
    }

    [Test]
    public void Test02()
    {
        Console.WriteLine($"animal result:{SwitchExpress01(new Animal())}");
        Console.WriteLine($"suer nova result:{SwitchExpress01(new SuerNova())}");
        Console.WriteLine($"null result :{SwitchExpress01(null)}");
    }

    /// <summary>
    /// switch表达式
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private bool Or(bool a, bool b) =>
        (a, b) switch
        {
            (_, true) => true,
            (true,_)=> true,
            (_, _) => false,
        };

    /// <summary>
    /// switch表达式02
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    private int SwitchExpress01(object? obj) => obj switch
    {
        Animal a => 1,
        SuerNova g => 2,
        not null => 0,
        null =>-1
        
    };
    
    // 行为、数据分离
}