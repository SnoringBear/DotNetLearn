namespace DotNetLearn.DataType;

public class InterfaceDemo
{
    [Test]
    public void Test01()
    {
        InterfaceImplementer demo = new InterfaceImplementer();
        demo.MethodToImplement();
    }

    interface IMyInterface
    {
        void MethodToImplement();
    }

    class InterfaceImplementer: IMyInterface
    {
        public void MethodToImplement()
        {
            Console.WriteLine("InterfaceImplementer");
        }
    }

}