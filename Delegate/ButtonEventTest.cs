namespace DotNetLearn.Delegate;

[TestFixture]
public class ButtonEventTest
{
    [Test]
    public void Test01()
    {
        Button button = new Button();
       
        // 订阅事件
        button.Click += Button_Click;

        // 引发事件
        button.OnClick();  // 输出 "Button clicked!"
    }

    private static void Button_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Button clicked!");
    }
}