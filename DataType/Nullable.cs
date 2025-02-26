namespace DotNetLearn.DataType;

/// <summary>
/// 可空类型
/// </summary>
[TestFixture]
public class Nullable
{
    [Test]
    public void Test01()
    {
        // ? 单问号用于对 int、double、bool 等无法直接赋值为 null 的数据类型进行 null 的赋值，意思是这个数据类型是 Nullable 类型的。
        int? ii = null;
        Console.WriteLine(ii);
    }

    [Test]
    public void Test02()
    {
        // ?? 双问号用于判断一个变量在为 null 的时候返回一个指定的值。
        int? num1 = null;
        int result = num1 ?? 4;
        Console.WriteLine("result :{0}", result);
    }
}