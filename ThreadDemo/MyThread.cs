
namespace DotNetLearn.ThreadDemo;
[TestFixture]
public class MyThread
{
    [Test]
    public void Test01()
    {
        Console.WriteLine("Thread.CurrentThread.Name:{0}",Thread.CurrentThread.Name);
    }

    [Test]
    public void Test02()
    {
        void Start() => Console.WriteLine("Thread.CurrentThread.Name:{0}", Thread.CurrentThread.Name);
        var thread = new Thread(Start)
        {
            Name = "Test02"
        };
        thread.Start();
        Thread.Sleep(1000);
        Console.WriteLine("执行结束");
    }
}