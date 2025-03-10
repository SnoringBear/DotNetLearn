
using System.Diagnostics;

namespace DotNetLearn.Attribute;

[TestFixture]
public class ConditionalDemo
{
    // 这个预定义特性标记了一个条件方法，其执行依赖于指定的预处理标识符。
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }

    [Test]
    public void Test01()
    {
        ConditionalDemo.Message("This is a message");
    }

    [Test]
    public void Test02()
    {
        # if DEBUG
            Console.WriteLine("调试模式启动");
        #endif
    }
}