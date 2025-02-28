namespace DotNetLearn.Collection;
[TestFixture]
public class DictionaryTest
{
    

    [Test]
    public void Test01()
    {
        // java Map
        Dictionary<String, int> dict = new Dictionary<String, int>();
        dict.Add("one", 1);
        dict.Add("two", 2);
        
        foreach (var (key, value) in dict)
        {
            Console.WriteLine("key:{0},value:{1}", key, value);
        }
    }
}