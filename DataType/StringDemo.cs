namespace DotNetLearn.DataType;
[TestFixture]
public class StringDemo
{
    [Test]
    public void Test01()
    {
        string str = " Hello    World ";
        string trim = str.Trim();
        string replace = trim.Replace(" ","");
        Console.WriteLine("replace:{0}", replace);
    }
}