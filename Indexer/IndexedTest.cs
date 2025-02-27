namespace DotNetLearn.Indexer;
[TestFixture]
public class IndexedTest
{
    // 定义一个属性（property）包括提供属性名称。索引器定义的时候不带有名称，但带有 this 关键字，它指向对象实例
    // 索引器可以被重载
    [Test]
    public void Test01()
    {
        IndexedNames names = new IndexedNames();
        names[0] = "Zara";
        names[1] = "Riz";
        names[2] = "Nuha";
        names[3] = "Asif";
        names[4] = "Davinder";
        names[5] = "Sunil";
        names[6] = "Rubic";
        for ( int i = 0; i < IndexedNames.size; i++ )
        {
            Console.WriteLine(names[i]);
        }
    }
}