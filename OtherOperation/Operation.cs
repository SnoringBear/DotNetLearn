namespace DotNetLearn.OtherOperation;

[TestFixture]
public class Operation
{
    [Test]
    public void Test01()
    {
        // 不支持 class、class instance
        int length = sizeof(Int64); // 字节数
        Console.WriteLine("int size of :{0}",length);
    }

    [Test]
    public void Test02()
    {
        Type type = typeof(TestObject);
        Console.WriteLine("type name :{0}",type.FullName);
    }

    [Test]
    public void Test03()
    {
        TestObject testObject = new TestObject();
        bool isObj = testObject is object;
        Console.WriteLine("is Obj:{0}",isObj);
    }

    [Test]
    public void Test04()
    {
        Object obj = new StringReader("Hello");
        StringReader r = obj as StringReader;
        Console.WriteLine("r:{0}",r);
    }

    private class TestObject
    {
    }

}