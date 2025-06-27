namespace DotNetLearn.MatchPattern;

[TestFixture]
public class AttributePattern
{
    [Test]
    public void Test01()
    {
        var car1 = new Car(2);
        Console.WriteLine($"Car1 result:[{CalculateToll01(car1)}]");
    }

    /// <summary>
    /// 属性模式测试01
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    private decimal CalculateToll01(object? obj) => obj switch
    {
        Car { Passengers: 0 } => 2.00m + 0.50m,
        Car { Passengers: 1 } => 2.00m,
        Car { Passengers: 2 } => 2.00m - 0.50m,
        Car => 2.00m - 1.00m,


        Taxi { Fares: 0 } => 3.50m + 1.00m,
        Taxi { Fares: 1 } => 3.50m,
        Taxi { Fares: 2 } => 3.50m - 0.50m,
        Taxi => 3.50m - 1.00m,


        Bus b when ((double)b.Riders / (double)b.Capacity) < 0.50 => 5.00m + 2.00m,
        Bus b when ((double)b.Riders / (double)b.Capacity) > 0.90 => 5.00m - 1.00m,
        Bus => 5.00m,


        DeliveryTruck t when (t.GrossWeight > 5000) => 10.00m + 5.00m,
        DeliveryTruck t when (t.GrossWeight < 3000) => 10.00m - 2.00m,
        DeliveryTruck => 10.00m,

        { } => throw new ArgumentException(message: "Not a known vehicletype", paramName: nameof(obj)),
        null => throw new ArgumentNullException(nameof(obj))
    };

    /// <summary>
    /// 属性测试02
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    public decimal CalculateToll02(object? obj) => obj switch
    {
        Car c=>c.Passengers switch
        {
            0 => 2.00m + 0.50m,
            1=>2.00m,
            2=>2.00m - 0.50m,   
            _ => 2.00m - 1.00m,
            
        },
        
        
        Taxi t=>t.Fares switch
        {
            0=>2.00m + 0.50m,
            1=>2.00m,
            2=>2.00m - 0.50m,
            _ => 2.00m - 1.00m,
        },
        
        
        Bus b when ((double)b.Riders / (double)b.Capacity) < 0.50 => 5.00m + 2.00m,
        Bus b when ((double)b.Riders / (double)b.Capacity) > 0.90 => 5.00m - 1.00m,
        Bus => 5.00m,


        DeliveryTruck t when (t.GrossWeight > 5000) => 10.00m + 5.00m,
        DeliveryTruck t when (t.GrossWeight < 3000) => 10.00m - 2.00m,
        DeliveryTruck => 10.00m,

        { } => throw new ArgumentException(message: "Not a known vehicletype", paramName: nameof(obj)),
        null => throw new ArgumentNullException(nameof(obj))
    };
}


public class Car(int passengers)
{
    public int Passengers { get; set; } = passengers;
}


public class DeliveryTruck(int grossWeight)
{
    public required int GrossWeight { get; set; } = grossWeight;
}


public class Taxi(int fares)
{
    public required int Fares { get; set; } = fares;
}


public class Bus(int riders, int capacity = 90)
{
    public required int Capacity { get; set; } = capacity;
    public required int Riders { get; set; } = riders;
}