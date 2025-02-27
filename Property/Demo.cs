namespace DotNetLearn.Property;
[TestFixture]
public class Demo
{
    [Test]
    public void Test01()
    {
        Student student = new Student();
        Console.WriteLine("student:{0}",student.ToString());
    }
}