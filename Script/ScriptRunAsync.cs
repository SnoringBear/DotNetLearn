using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace DotNetLearn.Script;

[TestFixture]
public class ScriptRunAsync
{
    
    public class Globals
    {
        public int A { get; set; }
        public int B { get; set; }
    }
    
    [Test]
    public async Task  Test01()
    {
        var filePath = Path.Combine(Environment.CurrentDirectory,"Script","myscript.csx"); 
        // 读取脚本文件
        var code = await File.ReadAllTextAsync(filePath);

        // 定义宿主上下文
        var globals = new Globals { A = 5, B = 7 };

        // 设置选项
        var options = ScriptOptions.Default
            .AddImports("System");

        // 执行脚本
        var result = await CSharpScript.EvaluateAsync<int>(
            code,
            options,
            globals
        );

        Console.WriteLine($"Script returned: {result}");
    }
}