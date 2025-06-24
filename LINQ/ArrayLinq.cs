namespace DotNetLearn.LINQ;
[TestFixture]
public class ArrayLinq
{
    [Test]
    public void Test01()
    {
        // data source
        int[] scores = { 97, 92, 81, 60 };
        // query expression
        IEnumerable<int> scoreQuery = from score in scores where score > 10 select score;

        foreach (int score in scoreQuery)
        {
            Console.WriteLine(score);
        }
    }

    [Test]
    public void Test02()
    {
        int[] numbers = [ 5, 10, 8, 3, 6, 12 ];
        var orderedEnumerable = numbers.Where(num=>num%2== 0).OrderBy(n=>n);
        Console.WriteLine(System.Environment.NewLine);
        foreach (var i in orderedEnumerable)
        {
            Console.WriteLine(i);
        }
    }
}