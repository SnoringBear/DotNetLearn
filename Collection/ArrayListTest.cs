using System.Collections;

namespace DotNetLearn.Collection;
[TestFixture]
public class ArrayListTest
{
    [Test]
    public void Test01()
    {
        // 所有元素被存储为 object 类型。这意味着它可以存储任意类型的对象,没有类型约束
        var arrayList = new ArrayList();
        arrayList.Add("string");
        arrayList.Add(1);
        arrayList.Add(new List<string> { "string" });
        foreach (object o in arrayList)
        {
            Console.WriteLine(o);
        }
    }

}