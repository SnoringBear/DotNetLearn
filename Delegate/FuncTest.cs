namespace DotNetLearn.Delegate;
[TestFixture]
public class FuncTest
{
    [Test]
    public void Test01()
    {
        Func<int, int> f = x => x + 1;
        Console.WriteLine("Func类型委托执行结果:{0}", f(21));
    }
}