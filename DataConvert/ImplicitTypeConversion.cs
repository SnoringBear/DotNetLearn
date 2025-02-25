namespace DotNetLearn.DataConvert;

[TestFixture]
public class ImplicitTypeConversion
{
    [Test]
    public void Test01()
    {
        // 从小的整数类型转换为大的整数类型，从派生类转换为基类
        byte b = 10;
        int c = b;
        Console.WriteLine("c:{0}",c);
    }

    private class A
    {
        public string? Name { get; set; }

        protected A()
        {
        }

        public A(string? name)
        {
            Name = name;
        }
    }
    
    private class B:A
    {
        private int Age { get; set; }

        public B(string name,int age)
        {   Name = name;
            Age = age;
        }
    }

    [Test]
    public void Test02()
    {
        var b = new B("tom",12);
        A a = b;
        Console.WriteLine("A.name :{0}",a.Name);
    }
}