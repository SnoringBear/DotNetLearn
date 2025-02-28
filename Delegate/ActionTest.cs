namespace DotNetLearn.Delegate;
[TestFixture]
public class ActionTest
{
    [Test]
    public void Test01()
    {
        Action01(()=>Console.WriteLine("测试委托类型Action"));
    }

    private static void Action01(Action ac)
    {
        ac?.Invoke();
    }
}