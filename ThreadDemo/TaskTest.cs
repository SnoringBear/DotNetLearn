namespace DotNetLearn.ThreadDemo;
[TestFixture]
public class TaskTest
{
    [Test]
    public void Test01()
    {
        // 方式1: 使用 Task.Run (最常用)
        Task task1 = Task.Run(() => 
        {
            // Thread.Sleep(11000);
            Console.WriteLine("Task 1 正在运行");
        });

        // 方式2: 使用 Task.Factory.StartNew
        Task task2 = Task.Factory.StartNew(() => 
        {   Thread.Sleep(119000);
            Console.WriteLine("Task 2 正在运行");
        });
        
        // 方式3: 直接实例化并启动
        var task3 = new Task(() => Console.WriteLine("Task 3 正在运行"));
        task3.Start();
        
        Task.WaitAll(task1, task2); // 等待多个任务完成
    }

    [Test]
    public void Test02()
    {
        Task<int> calculateTask = Task.Run(() => 
        {
            Thread.Sleep(1000); // 模拟耗时操作
            Console.WriteLine("Calculate Task");
            return 42;
        });

        // 获取结果(会阻塞直到任务完成)
        var result = calculateTask.Result;
        Console.WriteLine("Test02,result:{0}",result);
    }


    [Test]
    public void Test003()
    {
        Task calculateTask = Task.Run(() => Test03());
        Task.WaitAll(calculateTask);
        Console.WriteLine("Test003");
    }

    public  async Task Test03()
    {
        Task<int> calculateTask = Task.Run(() => 
        {
            Thread.Sleep(1000); // 模拟耗时操作
            bool background = Thread.CurrentThread.IsBackground;
            Console.WriteLine("当前线程是否是后台线程:{0}",background);
            Console.WriteLine("Calculate Task");
            return 42;
        });
        // 更好的方式是使用 await
        int result = await calculateTask;
        Console.WriteLine("Test03,result:{0}",result);
    }

    [Test]
    public void Test04()
    {
        ThreadPool.SetMinThreads(50, 50);
        var task = Task.Factory.StartNew(() =>
        {
            // 长时间运行的任务
            Thread.Sleep(1000);
            bool background = Thread.CurrentThread.IsBackground;
            Console.WriteLine("Background:{0}",background);
        },TaskCreationOptions.LongRunning);
        
        Task.WaitAll(task);
    }
}