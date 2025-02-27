#define DEBUG
namespace DotNetLearn;

[TestFixture]
public class PreprocessorDirectives
{
    [Test]
    public void Test01()
    {
#if DEBUG
        Console.WriteLine("Debug mode");
#elif RELEASE
    Console.WriteLine("Release mode");
#else
    Console.WriteLine("Other mode");
#endif
    }


}