namespace DotNetLearn.MatchPattern;
[TestFixture]
public class IsPattern
{
    // 判断对象类型 主要用于父类强转子类之前的判断  is  as
    [Test]
    public void Test01()
    {
        var g = new Giraffe();
        var a = new Animal();
        FreedMammals(g);
        FreedMammals(a);

        SuerNova sn = new SuerNova();
        TestForMammals(g);
        TestForMammals(sn);
    }

    /// <summary>
    /// 测试 is用法
    /// </summary>
    /// <param name="a"></param>
    static void FreedMammals(Animal a)
    {
        if (a is Mammal m)
        {
            m.Eat();
            return;
        }
        Console.WriteLine($"{a.GetType().Name} is not a Mammal");
    }

    /// <summary>
    /// 测试 as用法
    /// </summary>
    /// <param name="o"></param>
    static void TestForMammals(object o)
    {
        var m = o as Mammal;
        if (m != null)
        {
            Console.WriteLine(m.ToString());
            return;
        }
        Console.WriteLine($"{o.GetType().Name} is not a Mammal");
    }
    
    /// <summary>
    /// 测试 as用法
    /// </summary>
    /// <param name="o"></param>
    static void TestForMammals2(object o)
    {
        var m = o as Mammal;
        if (m != null)
        {
            Console.WriteLine(m.ToString());
            return;
        }
        Console.WriteLine($"{o.GetType().Name} is not a Mammal");
    }
}

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating.");
    }

    public override string ToString()
    {
        return "I am an animal";
    }
}

class Mammal : Animal
{
}

class Giraffe : Mammal
{
    
}

class SuerNova
{
}