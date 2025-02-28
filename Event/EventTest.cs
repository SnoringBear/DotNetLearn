namespace DotNetLearn.Event;
[TestFixture]
public class EventTest
{

    [Test]
    public void Test01()
    {
        // 发布者
        ProcessBusinessLogic process = new ProcessBusinessLogic();
        // 订阅者
        EventSubscriber subscriber = new EventSubscriber();

        // 订阅事件
        subscriber.Subscribe(process);

        // 启动过程
        process.StartProcess();

    }

}