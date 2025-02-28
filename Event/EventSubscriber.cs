namespace DotNetLearn.Event;

public class EventSubscriber
{
    public void Subscribe(ProcessBusinessLogic process)
    {
        // 本质就是利用委托多播
        process.ProcessCompleted += Process_ProcessCompleted;
    }

    private void Process_ProcessCompleted(object sender, EventArgs e)
    {
        Console.WriteLine("Process Completed!");
    }
}