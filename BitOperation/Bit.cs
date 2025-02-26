namespace DotNetLearn.BitOperation;
[TestFixture]
public class Bit
{
    [Test]
    public void Test01()
    {
        // &
        int a = 60;            /* 60 = 0011 1100 */  
        int b = 13;            /* 13 = 0000 1101 */
        int c = a & b;         /* 12 = 0000 1100 */
        Console.WriteLine("a & b = {0}",c);
    }

    [Test]
    public void Test02()
    {
        // |
        int a = 60;            /* 60 = 0011 1100 */  
        int b = 13;            /* 13 = 0000 1101 */
        int c = a | b;         /* 61 = 0011 1101 */
        Console.WriteLine("a | b = {0}",c);
    }

    [Test]
    public void Test03()
    {   
        // ^
        int a = 60;            /* 60 = 0011 1100 */  
        int b = 13;            /* 13 = 0000 1101 */
        int c = a ^ b;         /* 49 = 0011 0001 */
        Console.WriteLine("a ^ b = {0}",c);
    }

    [Test]
    public void Test04()
    {
        // ~
        int a = 60;            /* 60 = 0011 1100 */
        int c = ~a;            /*-61 = 1100 0011 */
        Console.WriteLine("~a = {0}",c);
    }

    [Test]
    public void Test05()
    {   // <<
        int a = 60;            /* 60 = 0011 1100 */
        int c = a << 2;        /* 240 = 1111 0000 */
        Console.WriteLine("a << 2 = {0}", c);
    }

    [Test]
    public void Test06()
    {
        // >>
        int a = 60;            /* 60 = 0011 1100 */
        int c = a >> 2;        /* 15 = 0000 1111 */ 
        Console.WriteLine("a >> 2 = {0}", c);
    }
}