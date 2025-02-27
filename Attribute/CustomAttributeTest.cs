namespace DotNetLearn.Attribute;
[TestFixture]
public class CustomAttributeTest
{
    [DeBugInfo(55,"anye","2025.1.2",Message = "超级bug来源")]
    public static void Print()
    {
        Console.WriteLine("CustomAttributeTest 类执行逻辑");
    }

    [Test]
    public void Test01()
    {
        CustomAttributeTest.Print();
    }
}