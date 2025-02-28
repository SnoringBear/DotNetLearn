namespace DotNetLearn.Event;

public class EventSubscriber
{
    public void Subscribe(ProcessBusinessLogic process)
    {
        process.ProcessCompleted += Process_ProcessCompleted;
    }

    private void Process_ProcessCompleted(object sender, EventArgs e)
    {
        Console.WriteLine("Process Completed!");
    }
}