namespace DotNetLearn.DataType;
[TestFixture]
public class EnumDemo
{
    [Test]
    public void Test01()
    {
        Console.WriteLine("Days.Sun:{0}", Days.Sun);
    }

}

enum Days
{
    // 枚举是一组命名整型常量
    Sun, Mon, tue, Wed, thu, Fri, Sat
}