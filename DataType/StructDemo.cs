namespace DotNetLearn.DataType;

/// <summary>
/// 在 C# 中，结构体（struct）是一种值类型（value type），用于组织和存储相关数据。
/// </summary>

public class StructDemo
{

    [Test]
    public void Test01()
    {
        Book book;
        book.book_id = 12345;
        book.title = "c#教程";
        book.author = "anye";
        book.subject = "IT";
        Console.WriteLine("book:{0}",book);
    }


}

struct Book
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
}