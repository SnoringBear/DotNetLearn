using System.Collections;

namespace DotNetLearn.Collection;
[TestFixture]
public class HashtableTest
{
    [Test]
    public void Test01()
    {
        // 没有类型约束 底层  Add(object key, object? value)
        Hashtable ht = new Hashtable
        {
            { 1, 2 },
            { "hello", null }
        };
        foreach (DictionaryEntry o in ht)
        {
            Console.WriteLine("key:{0},value:{1}",o.Key,o.Value);
        }
    }
}