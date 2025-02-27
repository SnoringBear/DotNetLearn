
namespace DotNetLearn.Attribute;
[AttributeUsage(validOn:AttributeTargets.All)]
public class AttributeUsageDemoAttribute:System.Attribute
{
    // AttributeUsage类的作用就是帮助我们控制 定制特性 的使用
    // 类似与Java Annotation      c# AttributeUsage-> Java @Target
}