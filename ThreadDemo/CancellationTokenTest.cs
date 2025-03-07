namespace DotNetLearn.ThreadDemo;
[TestFixture]
public class CancellationTokenTest
{

    [Test]
    public void Test01()
    {
        Task testCancellation = TestCancellation();
        testCancellation.Wait();
    }

    private static async Task TestCancellation()
    {
        using var cts = new CancellationTokenSource();

        Task task = DoWorkAsync(cts.Token);

        // 模拟用户在 2 秒后取消任务
        await Task.Delay(2000, cts.Token);
        await cts.CancelAsync();

        try
        {
            await task; // 等待任务完成，观察是否抛出异常
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("任务已被取消。");
        }
        finally
        {
            Console.WriteLine("----------------------------");
        }
    }

    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested(); // 检查是否收到取消请求

            Console.WriteLine($"执行任务中... {i + 1}");
            await Task.Delay(1000); // 模拟耗时任务
        }
    }
}