namespace DotNetLearn.Event;
// 定义一个委托类型，用于事件处理程序
public delegate void NotifyEventHandler(object sender, EventArgs e);

public class ProcessBusinessLogic
{
    // 声明事件       
    public event NotifyEventHandler ProcessCompleted;
    
    // 触发事件的方法
    protected virtual void OnProcessCompleted(EventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }
    
    // 模拟业务逻辑过程并触发事件
    public void StartProcess()
    {
        Console.WriteLine("Process Started!");

        // 这里可以加入实际的业务逻辑

        // 业务逻辑完成，触发事件
        OnProcessCompleted(EventArgs.Empty);
    }
}