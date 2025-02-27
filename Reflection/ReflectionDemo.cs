using System.Reflection;
using DotNetLearn.Attribute;

namespace DotNetLearn.Reflection;
[TestFixture]
public class ReflectionDemo
{
    [Test]
    // 反射指程序可以访问、检测和修改它本身状态或行为的一种能力。
    public void Test01()
    {
        System.Reflection.MemberInfo info = typeof(CustomAttributeTest);
        object[] customAttributes = info.GetCustomAttributes(true);
        foreach (object customAttribute in customAttributes)
        {
            Console.WriteLine(customAttribute);
        }
    }

    [Test]
    public void Test02()
    {
        Type type = typeof(CustomAttributeTest);
        MethodInfo[] methodInfos = type.GetMethods();
        foreach (MethodInfo methodInfo in methodInfos)
        {
            object[] customAttributes = methodInfo.GetCustomAttributes(true);
            foreach (object attribute in customAttributes)
            {
                Console.WriteLine("function name :{0},attribute:{1}",methodInfo.Name,attribute.GetType().Name);
            }
        }
    }
}