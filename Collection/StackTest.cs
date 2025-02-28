namespace DotNetLearn.Collection;
[TestFixture]
public class StackTest
{
    // 在 C# 中，堆栈（Stack） 是一种后进先出（LIFO, Last In First Out）的数据结构。
    // 堆栈（Stack）适用于存储和按顺序处理数据，其中最新添加的元素会最先被移除。


    [Test]
    public void Test01()
    {
        // 可以使用泛型,也可以使用非泛型,泛型性能更优
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        
        // 先进后出
        foreach (var i in stack)
        {
            Console.WriteLine("i:{0}",i);
        }
    }
}