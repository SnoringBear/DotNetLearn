namespace DotNetLearn.Property;

public class Student:Person
{
   

    // 抽象类可拥有抽象属性，这些属性应在派生类中被实现
    public override string Name { get; set; }= "N.A";
    public override int Age { get; set; }= 0;
    public string Code { get; set; } = "N.A";
    
    public override string ToString()
    {
        return $"Code = {Code}, Name = {Name}, Age = {Age}";
    }
    
}