namespace DotNetLearn.ParameterPassing;

/// <summary>
/// 输出传递参数
/// </summary>
[TestFixture]
public class OutPassing
{
    [Test]
    public void Test()
    {
        OutPassing pass = new OutPassing();
        int a = 200;
        Console.WriteLine("方法调用之前，a 的值： {0}", a);
        pass.GetValue(out a);
        Console.WriteLine("方法调用之后，a 的值： {0}", a);
        
        // 调用之前 200
        // 调用之后 0
        
    }
    
    private void GetValue(out int x)
    {
        x = 0;
    }
}