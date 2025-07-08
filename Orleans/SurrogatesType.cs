namespace DotNetLearn.Orleans;

public class SurrogatesType
{
}

// This is the foreign type, which you do not have control over.
public struct MyForeignLibraryValueType
{
    public MyForeignLibraryValueType(int num, string str, DateTimeOffset dto)
    {
        Num = num;
        String = str;
        DateTimeOffset = dto;
    }

    public int Num { get; }
    public string String { get; }
    public DateTimeOffset DateTimeOffset { get; }
}


// This is the surrogate which will act as a stand-in for the foreign type.
// Surrogates should use plain fields instead of properties for better performance.
[GenerateSerializer]
public struct MyForeignLibraryValueTypeSurrogate
{
    [Id(0)] public int Num;
    [Id(1)] public string String;
    [Id(2)] public DateTimeOffset DateTimeOffset;
}


// This is a converter that converts between the surrogate and the foreign type.
[RegisterConverter]
public sealed class MyForeignLibraryValueTypeSurrogateConverter :
    IConverter<MyForeignLibraryValueType, MyForeignLibraryValueTypeSurrogate>
{
    public MyForeignLibraryValueType ConvertFromSurrogate(
        in MyForeignLibraryValueTypeSurrogate surrogate) =>
        new(surrogate.Num, surrogate.String, surrogate.DateTimeOffset);

    public MyForeignLibraryValueTypeSurrogate ConvertToSurrogate(
        in MyForeignLibraryValueType value) =>
        new()
        {
            Num = value.Num,
            String = value.String,
            DateTimeOffset = value.DateTimeOffset
        };
}