namespace DotNetLearn.Delegate;
[TestFixture]
public class PredicateTest
{
    [Test]
    public void Test01()
    {
        Predicate<int> isEven = x => x % 2 == 0;
        Console.WriteLine("Predicate委托类型执行结果:{0}",isEven(4));  // 输出 True
    }
}