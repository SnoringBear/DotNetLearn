namespace DotNetLearn.ParameterPassing;
/// <summary>
/// 值传递参数
/// </summary>
[TestFixture]
public class ValuePassing
{
    [Test]
    public void Test()
    {
        ValuePassing pass = new ValuePassing();
        int a = 200;
        int b = 100;
        Console.WriteLine("交换之前，a 的值： {0}", a);
        Console.WriteLine("交换之前，b 的值： {0}", b);
        pass.Swap(a,b);
        Console.WriteLine("交换之后，a 的值： {0}", a);
        Console.WriteLine("交换之后，b 的值： {0}", b);
        
        
        // 交换之前，a 的值： 200
        // 交换之前，b 的值： 100
        // 交换之后，a 的值： 200
        // 交换之后，b 的值： 100
    }

    private void Swap(int x, int y)
    {
        int temp;
         
        temp = x; /* 保存 x 的值 */
        x = y;    /* 把 y 赋值给 x */
        y = temp; /* 把 temp 赋值给 y */
    }
    
    
}