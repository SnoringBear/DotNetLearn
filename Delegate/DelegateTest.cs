namespace DotNetLearn.Delegate;
delegate int NumberChanger(int n);
public class DelegateTest
{
    static int num = 10;
    public static int AddNum(int p)
    {
        num += p;
        return num;
    }
    public static int MultNum(int q)
    {
        num *= q;
        return num;
    }
    
    public static int getNum()
    {
        return num;
    }

    [Test]
    public void Test01()
    {
        int invoke = new NumberChanger(AddNum).Invoke(num);
        Console.WriteLine("invoke:{0}", invoke);
    }

    [Test]
    public void Test02()
    {
        // 委托对象可使用 + 运算符进行合并。
        // 一个合并委托调用它所合并的两个委托，只有相同类型的委托可被合并。
        // - 运算符可用于从合并的委托中移除组件委托
        // 创建委托实例
        NumberChanger nc;
        NumberChanger nc1 = new NumberChanger(AddNum);
        NumberChanger nc2 = new NumberChanger(MultNum);
        nc = nc1;
        nc += nc2;
        // 调用多播
        nc(5);
        Console.WriteLine("Value of Num: {0}", getNum());
    }

}