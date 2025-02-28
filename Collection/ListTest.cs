namespace DotNetLearn.Collection;
[TestFixture]
public class ListTest
{
    [Test]
    public void Test01()
    {
        var list = new List<int>
        {
            1,
            2,
            3
        };
        list.ForEach(a=>Console.WriteLine(a.ToString()));

    }
}