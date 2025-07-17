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

    
    
    /// <summary>
    /// This is an asynchronous test method that executes a C# script file, evaluates its result,
    /// and prints the output to the console.
    /// </summary>
    [Test]
    public async Task Test01()
    {
        var filePath = Path.Combine(Environment.CurrentDirectory,"Script","myscript.csx");
        // Read the script file
        var code = await File.ReadAllTextAsync(filePath);

        // Define host context
        var globals = new Globals { A = 5, B = 7 };

        // Set options
        var options = ScriptOptions.Default
            .AddImports("System");

        // Execute script
        var result = await CSharpScript.EvaluateAsync<int>(
            code,
            options,
            globals
        );

        Console.WriteLine($"Script returned: {result}");
    }
}