namespace DotNetLearn.DataType;

public record Point(int x,int y);

[TestFixture]
public class PointDemo
{
    [Test]
    public void Test1()
    {
        Point p1 = new Point(2, 3);
        var p2 = p1 with { y = 20 };
        
        Console.WriteLine($"p1:{p1},p2:{p2}");
    }
}