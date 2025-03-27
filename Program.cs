using DotNetLearn.ThreadDemo;

namespace DotNetLearn;

public class Program
{
    public static void Main(string[] args)
    {
        var taskTest = new TaskTest();
        _ = taskTest.Test03();
        
        Thread.Sleep(122222);
    }
}