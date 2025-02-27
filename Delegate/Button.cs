namespace DotNetLearn.Delegate;

public class Button
{
    // 定义一个事件
    public event EventHandler Click;

    // 引发事件的方法
    public void OnClick()
    {
        if (Click != null)
        {
            Click(this, EventArgs.Empty);  // 调用事件
        }
    }
}