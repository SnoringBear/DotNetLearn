namespace DotNetLearn.DataType;

[TestFixture]
public class ReferenceTypes
{
    [Test]
    public void TestObject()
    {
        object obj = 100;
        Console.WriteLine("obj type :{0}", obj.GetType());
        object obj2 = 100L;
        Console.WriteLine("obj2 type :{0}", obj2.GetType());
        // 对象类型变量的类型检查是在编译时发生的
    }

    [Test]
    public void TestDynamic()
    {
        dynamic dy = 100;
        Console.WriteLine("dy type :{0}", dy.GetType());
        // 您可以存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的
    }

    [Test]
    public void TestString()
    {
        const string str1 = "C:\\Windows";
        // C# string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待
        const string str2 = @"C:\Windows";
        Console.WriteLine("str1 :{0}", str1);
        Console.WriteLine("str2 :{0}", str2);
    }
}