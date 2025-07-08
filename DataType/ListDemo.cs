using System.Xml.Linq;

namespace DotNetLearn.DataType;
[TestFixture]
public class ListDemo
{
    [Test]
    public void Test01()
    {
        var words = new List<int> { 4, 6, 9 };
        words.Insert(0, 10);
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }

    [Test]
    public void Test02()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = from n in numbers
            where n % 2 == 0
            select n;

        foreach (var n in evenNumbers)
        {
            Console.WriteLine(n); // input data
        }
    }

    [Test]
    public void Test03()
    {
        var dict = new Dictionary<string, int>
        {
            ["apple"] = 5,
            ["banana"] = 2
        };

        var result = dict.Where(kvp => kvp.Value > 3);
    }

    
    [Test]
    public void Test04()
    {
        var set = new HashSet<int> { 1, 2, 3 };
        var result = set.Select(x => x * 10);
    }

    [Test]
    public void Test05()
    {
        var doc = XDocument.Load("file.xml");
        var items = doc.Descendants("Item")
            .Where(x => (int)x.Attribute("Price") > 100);
    }

    [Test]
    public void Test06()
    {
        Console.WriteLine("开始测试");
        for (int i = 0; i < 100000; i++)
        {
            var range = (int)((0.03 - 0.005) * 10000);// 放大倍数处理
            var difference = Random.Shared.Next(0, range) / 10000.0;
            var t = difference * 0.5 + 0.005;
            t = Math.Round(t, 3);
            // Console.WriteLine(t); // 输出随机数
            if(t > 0.03 || t < 0.005)
            {
                Console.WriteLine("Error: {0}", t);
            }
        }
    }
    
    [Test]
    public void Test07()
    {
        Console.WriteLine("开始测试");
        for (int i = 0; i < 100000; i++)
        {
            var random = Random.Shared.NextDouble()* (0.03 - 0.005)*0.5 + 0.005; // 生成0.005到0.03之间的随机数
            random = Math.Round(random, 3);
            // Console.WriteLine(t); // 输出随机数
            if(random > 0.03 || random < 0.005)
            {
                Console.WriteLine("Error: {0}", random);
            }
        }
    }
}