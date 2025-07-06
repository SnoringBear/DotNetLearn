namespace DotNetLearn.ThreadDemo;
[TestFixture]
public class TaskTest
{
    // Core APIs for C# asynchronous programming: async, await, task
    [Test]
    public void Test01()
    {
        // Method 1: Use Task.Run (most common)
        Task task1 = Task.Run(() =>
        {
            // Thread.Sleep(11000);
            Console.WriteLine("Task 1 is running");
        });

        // Method 2: Use Task.Factory.StartNew
        Task task2 = Task.Factory.StartNew(() =>
        {
            Thread.Sleep(119000);
            Console.WriteLine("Task 2 is running");
        });

        // Method 3: Instantiate and start directly
        var task3 = new Task(() => Console.WriteLine("Task 3 is running"));
        task3.Start();

        Task.WaitAll(task1, task2); // Wait for multiple tasks to complete
    }

    [Test]
    public void Test02()
    {
        Task<int> calculateTask = Task.Run(() =>
        {
            Thread.Sleep(1000); // Simulate time-consuming operation
            Console.WriteLine("Calculate Task");
            return 42;
        });

        // Get result (will block until the task is complete)
        var result = calculateTask.Result;
        Console.WriteLine("Test02,result:{0}", result);
    }


    [Test]
    public void Test003()
    {
        Task calculateTask = Task.Run(() => Test03());
        Task.WaitAll(calculateTask);
        Console.WriteLine("Test003");
    }

    public async Task Test03()
    {
        Task<int> calculateTask = Task.Run(() =>
        {
            Thread.Sleep(1000); // Simulate time-consuming operation
            bool background = Thread.CurrentThread.IsBackground;
            Console.WriteLine("Is current thread a background thread:{0}", background);
            Console.WriteLine("Calculate Task");
            return 42;
        });
        // A better way is to use await
        int result = await calculateTask;
        Console.WriteLine("Test03,result:{0}", result);
    }

    [Test]
    public void Test04()
    {
        ThreadPool.SetMinThreads(50, 50);
        var task = Task.Factory.StartNew(() =>
        {
            // Long-running task
            Thread.Sleep(1000);
            bool background = Thread.CurrentThread.IsBackground;
            Console.WriteLine("Background:{0}", background);
        }, TaskCreationOptions.LongRunning);

        Task.WaitAll(task);
    }

    public static async Task<int> GetPageLengthAsync(string endpoint)
    {
        var client = new HttpClient();
        var uri = new Uri(endpoint);
        byte[] content = await client.GetByteArrayAsync(uri);
        return content.Length;
    }
}