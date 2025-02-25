namespace DotNetLearn.DataType;
[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestSize()
    {
        Console.WriteLine("Size of int: {0}", sizeof(int));
        Console.WriteLine("Size of long: {0}", sizeof(long));
        Console.WriteLine("Size of double: {0}", sizeof(double));
    }

    [Test]
    public void TestMaxOrMinValue()
    {
        Console.WriteLine("int Max: {0},int min: {1}", int.MaxValue, int.MinValue);
        Console.WriteLine("long Max: {0},long min: {1}", long.MaxValue, long.MinValue);
    }
}