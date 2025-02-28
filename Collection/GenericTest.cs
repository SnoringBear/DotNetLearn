namespace DotNetLearn.Collection;
[TestFixture]
public class GenericTest
{
    // 泛型（Generic） 允许您延迟编写类或方法中的编程元素的数据类型的规范，直到实际在程序中使用它的时候。换句话说，
    // 泛型允许您编写一个可以与任何数据类型一起工作的类或方法
    
    [Test]
    public void Test01()
    {
        MyGenericArray<int> intArray = new MyGenericArray<int>(5);
        for (int c = 0; c < 5; c++)
        {
            intArray.setItem(c, c*5);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("position:{0},value:{1}",i,intArray.getItem(i));
        }
    }
    
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
}