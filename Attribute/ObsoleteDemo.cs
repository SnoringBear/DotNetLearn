namespace DotNetLearn.Attribute;
[TestFixture]
public class ObsoleteDemo
{
    // 这个预定义特性标记了不应被使用的程序实体
    
    [Obsolete("Don't use OldMethod, use NewMethod instead", false)]
    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }

    [Test]
    public void Test01()
    {
        ObsoleteDemo.OldMethod();
    }
}