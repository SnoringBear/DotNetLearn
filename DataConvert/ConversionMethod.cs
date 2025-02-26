namespace DotNetLearn.DataConvert;
[TestFixture]
public class ConversionMethod
{
    [Test]
    public void Test01()
    {
        // 使用Convert转换
        string str = "123";
        int result = Convert.ToInt32(str);
        Console.WriteLine("convert str to int :{0}", result);
    }

    [Test]
    public void Test02()
    {   // Parse 方法
        string str = "123";
        var result = int.Parse(str);
        Console.WriteLine("convert str to int :{0}", result);
    }

    [Test]
    public void Test03()
    {
        // TryParse 方法
        string str = "123";
        int result;
        // 在 C# 中，out 是一个关键字，用于指示参数通过引用传递，并且必须在方法返回前由被调用的方法赋值。out 参数通常用于方法需要返回多个值的情况
        bool success = int.TryParse(str,out result);
        Console.WriteLine("convert str to int result :{0},success:{1}", result,success);
    }
}