namespace DotNetLearn.DataType;
[TestFixture]
public class ListDemo
{
    [Test]
    public void Test01()
    {
        var words = new List<int> { 4, 6, 9 };
        words.Insert(0, 10);
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}