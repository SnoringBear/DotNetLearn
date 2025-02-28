using System.Collections;

namespace DotNetLearn.Collection;
[TestFixture]
public class QueueTest
{
    // 在 C# 中，Queue 是一个先进先出（FIFO, First In First Out）数据结构
    // Queue 适用于需要按照入队顺序处理数据的场景。
    // Queue 本身不是线程安全的，但可以使用 ConcurrentQueue<T> 实现线程安全。
    
    [Test]
    public void Test01()
    {
        Queue<String> queue = new Queue<String>();

        // 添加元素
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        
        Console.WriteLine("queue first:{0}",queue.Peek());
        
        foreach (string s in queue)
        {
            Console.WriteLine("s:{0}",s);
        }
        
        // 检查包含
        Console.WriteLine($"Contains 'Second': {queue.Contains("Second")}"); // 输出：True

        // 转数组
        object[] array = queue.ToArray();
        Console.WriteLine($"Array Length: {array.Length}"); // 输出：2
    }
}