namespace DotNetLearn.DataType;
[TestFixture]
public class ClassDemo
{
    public ClassDemo()
    {
        Console.WriteLine("创建对象");
    }

    ~ClassDemo()
    {
        // 类的 析构函数 是类的一个特殊的成员函数，当类的对象超出范围时执行。
        // 析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载
        Console.WriteLine("释放对象");
    }

    [Test]
    public void Test01()
    {
        ClassDemo demo = new ClassDemo();
        Console.WriteLine(demo.GetType());
    }

    [Test]
    public void Test02()
    {
        var circle = new Circle();
        circle.Draw();
    }

    class Shape
    {
        public virtual void Draw()
        {
            // 虚方法是使用关键字 virtual 声明的。
            // 虚方法可以在不同的继承类中有不同的实现
            Console.WriteLine("父类Draw方法");
        }
    }

    class Circle: Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("子类Draw方法");
        }
    }
}


sealed class ClassTest1
{
    // 通过在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。
}
