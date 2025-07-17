using System.Collections;

namespace DotNetLearn.Collection;
[TestFixture]
public class ArrayListTest
{
    [Test]
    public void Test01()
    {
        // 所有元素被存储为 object 类型。这意味着它可以存储任意类型的对象,没有类型约束
        var arrayList = new ArrayList
        {
            "string",
            1,
            new List<String> { "string" }
        };
        foreach (var o in arrayList)
        {
            Console.WriteLine(o);
        }
    }
    
    
    public void Test02()
    {
        var datas = new List<Int32> { 1, 2, 3, 4, 5 };

        datas = [.. datas.Where(x => x > 1)];
    }

}