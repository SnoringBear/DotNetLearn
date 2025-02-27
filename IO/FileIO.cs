namespace DotNetLearn.IO;
[TestFixture]
public class FileIO
{
    [Test]
    public void Test01()
    {
        FileStream F = new FileStream(Path.Combine(Directory.GetCurrentDirectory(),"test.txt"),
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

        for (int i = 1; i <= 20; i++)
        {
            F.WriteByte((byte)i);
        }

        F.Position = 0;

        for (int i = 0; i <= 20; i++)
        {
            Console.Write(F.ReadByte() + " ");
        }
        F.Close();
    }
}