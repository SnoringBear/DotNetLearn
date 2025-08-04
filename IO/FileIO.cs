namespace DotNetLearn.IO;

[TestFixture]
public class FileIO
{
    [Test]
    public void Test01()
    {
        FileStream F = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "test.txt"),
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

    [Test]
    public void Test02()
    {
        // 演示如何通过文件全路径名获取其文件路径
        string fullPath = @"D:\github\DotNetLearn\IO\FileIO.json";
        // 方法1：Path.GetDirectoryName
        string? dir1 = Path.GetDirectoryName(fullPath);
        Console.WriteLine($"Path.GetDirectoryName: {dir1}");

        // 方法2：FileInfo.DirectoryName
        FileInfo fi = new FileInfo(fullPath);
        string? dir2 = fi.DirectoryName;
        Console.WriteLine($"FileInfo.DirectoryName: {dir2}");

        // 方法3：字符串操作
        int idx = fullPath.LastIndexOf(Path.DirectorySeparatorChar);
        string dir3 = idx > 0 ? fullPath.Substring(0, idx) : string.Empty;
        Console.WriteLine($"Substring: {dir3}");
    }

    // 可复用的静态方法
    public static string? GetDirectoryFromFullPath(string fullPath)
    {
        return Path.GetDirectoryName(fullPath);
    }
}