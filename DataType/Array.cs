namespace DotNetLearn.DataType;
[TestFixture]
public class Array
{
    [Test]
    public void Test01()
    {
        int[] array = [1, 2, 3];
        Console.WriteLine("array length:{0}",array.Length);
        foreach (var i in array)
        {
            Console.WriteLine(i);
        }
    }
}