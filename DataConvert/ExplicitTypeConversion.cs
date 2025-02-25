namespace DotNetLearn.DataConvert;
[TestFixture]
public class ExplicitTypeConversion
{
    [Test]
    public void Test01()
    {
        int a = 10;
        byte b = (byte)a;
        Console.WriteLine("b:{0}",b);
    }

    [Test]
    public void Test02()
    {
        long a = long.MaxValue;
        byte b = (byte)a;
        Console.WriteLine("byte maxValue:{0},b:{1}",byte.MaxValue,b);
    }
}