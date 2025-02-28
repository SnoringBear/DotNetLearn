namespace DotNetLearn.Collection;
[TestFixture]
public class SortedListTest
{
    // 排序列表（SortedList） 是一种按键自动排序的集合
    // 排序列表是数组和哈希表的组合。它包含一个可使用键或索引访问各项的列表。
    // 如果您使用索引访问各项，则它是一个动态数组（ArrayList），如果您使用键访问各项，则它是一个哈希表（Hashtable）
    // 可以使用泛型
    [Test]
    public void Test01()
    {
        SortedList<int, string> list = new SortedList<int, string>();
        list.Add(1, "one");
        list.Add(2, "two");
        list.Add(3, "three");
        
        list[4] = "four";
        
        foreach (var (key, value) in list)
        {
            Console.WriteLine("key:{0},value:{1}",key,value);
        }
        
        list.Remove(1);
        Console.WriteLine("移除元素后");
        foreach (var (key, value) in list)
        {
            Console.WriteLine("key:{0},value:{1}",key,value);
        }
    }
}