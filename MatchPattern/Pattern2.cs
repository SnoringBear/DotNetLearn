namespace DotNetLearn.MatchPattern;

[TestFixture]
public class Pattern2
{
    [Test]
    public void Test01()
    {
        const int a = 5;
        int? j = null;
        const double d = 9.346;
        
        PatternMatchingSwitch(a);
        PatternMatchingSwitch(j);
        PatternMatchingSwitch(d);
    }

    [Test]
    public void Test02()
    {
        Giraffe g = new();
        UseIsOprerator(g);
    }

    /// <summary>
    /// 类型判断
    /// </summary>
    /// <param name="val"></param>
    private void PatternMatchingSwitch(ValueType? val)
    {
        switch (val)
        {
            case int number:
                Console.WriteLine("The value of number is: " + number);
                break;
            case long number:
                Console.WriteLine("The value of number is: " + number);
                break;
            case double number:
                Console.WriteLine("The value of number is: " + number);
                break;
            case float number:
                Console.WriteLine("The value of number is: " + number);
                break;
            case decimal number:
                Console.WriteLine("The value of number is: " + number);
                break;
            default:
                Console.WriteLine("The value of number is: " + val);
                break;
        }
    }


    static void UseIsOprerator(Animal animal)
    {
        if (animal is Mammal m)
        {
            m.Eat();
        }
    }
}