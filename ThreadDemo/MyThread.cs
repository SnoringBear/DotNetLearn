
namespace DotNetLearn.ThreadDemo;
[TestFixture]
public class MyThread
{
    [Test]
    public void Test01()
    {
        Console.WriteLine("Thread.CurrentThread.Name:{0}",Thread.CurrentThread.Name);
    }
}