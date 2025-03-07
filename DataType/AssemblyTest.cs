namespace DotNetLearn.DataType;
[TestFixture]
public class AssemblyTest
{
    [Test]
    public void Test01()
    {
        Console.WriteLine(typeof(AssemblyTest).Assembly);
        Console.WriteLine("foreach GetTypes()-----");
        foreach (var type in typeof(AssemblyTest).Assembly.GetTypes())
        {
            Console.WriteLine(type);
        }
    }
}