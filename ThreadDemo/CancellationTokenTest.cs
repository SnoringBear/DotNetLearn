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


    /// <summary>
    /// Tests the cancellation of an asynchronous task using a CancellationToken.
    /// </summary>
    private static async Task TestCancellation()
    {
        using var cts = new CancellationTokenSource();

        Task task = DoWorkAsync(cts.Token);

        // Simulate user canceling the task after 2 seconds
        await Task.Delay(2000, cts.Token);
        await cts.CancelAsync();

        try
        {
            await task; // Wait for the task to complete and observe if an exception is thrown
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("The task has been canceled.");
        }
        finally
        {
            Console.WriteLine("----------------------------");
        }
    }

    /// <summary>
    /// Performs a simulated long-running task, periodically checking for cancellation requests.
    /// Throws <see cref="OperationCanceledException"/> if cancellation is requested.
    /// </summary>
    /// <param name="token">A <see cref="CancellationToken"/> to observe for cancellation requests.</param>
    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested(); // Check if a cancellation request has been received

            Console.WriteLine($"Task in progress... {i + 1}");
            await Task.Delay(1000); // Simulate a time-consuming task
        }
    }
}