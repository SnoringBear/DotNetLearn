﻿namespace DotNetLearn.ThreadDemo;

[TestFixture]
public class AsyncBreakfast
{
    [Test]
    public void Test01()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("coffee is ready");
        
        
        Egg eggs = FryEggs(2);
        Console.WriteLine("eggs are ready");
        
        
        Bacon bacon = FryBacon(3);
        Console.WriteLine("bacon is ready");
        
        
        Toast toast = ToastBread(2);
        ApplyButter(toast);
        ApplyJam(toast);
        Console.WriteLine("toast is ready");
        
        
        Juice oj = PourOJ();
        Console.WriteLine("oj is ready");
        Console.WriteLine("Breakfast is ready!");
    }

    [Test]
    public async Task Test02()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("coffee is ready");
        Egg eggs = await FryEggsAsync(2);
        Console.WriteLine("eggs are ready");
        Bacon bacon = await FryBaconAsync(3);
        Console.WriteLine("bacon is ready");
        Toast toast = await ToastBreadAsync(2);
        Console.WriteLine("------------await after-----------");
        ApplyButter(toast);
        ApplyJam(toast);
        Console.WriteLine("toast is ready");
        Juice oj = PourOJ();
        Console.WriteLine("oj is ready");
        Console.WriteLine("Breakfast is ready!");
        
    }
    
    [Test]
    public async Task Test03()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("coffee is ready");
        Task<Egg> eggs =  Task.Run(()=>FryEggsAsync(2));
        Console.WriteLine("eggs are ready");
        Task<Bacon> bacon = Task.Run(() => FryBaconAsync(3));
        Console.WriteLine("bacon is ready");
        Task<Toast> toast =  Task.Run(()=>ToastBreadAsync(2));
        Console.WriteLine("------------await after-----------");
        Task.WaitAll(eggs, bacon, toast);
        // ApplyButter(toast);
        // ApplyJam(toast);
        Console.WriteLine("toast is ready");
        Juice oj = PourOJ();
        Console.WriteLine("oj is ready");
        Console.WriteLine("Breakfast is ready!");
        
    }

    private static Juice PourOJ()
    {
        Console.WriteLine("Pouring orange juice");
        return new Juice();
    }

    private static void ApplyJam(Toast toast) =>
        Console.WriteLine("Putting jam on the toast");

    private static void ApplyButter(Toast toast) =>
        Console.WriteLine("Putting butter on the toast");

    private static Toast ToastBread(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
        }

        Console.WriteLine("Start toasting...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Remove toast from toaster");
        return new Toast();
    }
    
    private static Task<Toast> ToastBreadAsync(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
        }

        Console.WriteLine("Start toasting...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Remove toast from toaster");
        return Task.FromResult(new Toast());
    }

    private static Bacon FryBacon(int slices)
    {
        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        Task.Delay(3000).Wait();
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }

        Console.WriteLine("cooking the second side of bacon...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put bacon on plate");
        return new Bacon();
    }
    
    private static Task<Bacon> FryBaconAsync(int slices)
    {
        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        Task.Delay(3000).Wait();
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }

        Console.WriteLine("cooking the second side of bacon...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put bacon on plate");
        return Task.FromResult(new Bacon());
    }

    private static Egg FryEggs(int howMany)
    {
        Console.WriteLine("Warming the egg pan...");
        Task.Delay(3000).Wait();
        Console.WriteLine($"cracking {howMany} eggs");
        Console.WriteLine("cooking the eggs ...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put eggs on plate");
        return new Egg();
    }
    
    private Task<Egg> FryEggsAsync(int howMany)
    {
        Console.WriteLine("Warming the egg pan...");
        Task.Delay(3000).Wait();
        Console.WriteLine($"cracking {howMany} eggs");
        Console.WriteLine("cooking the eggs ...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put eggs on plate");
        return Task.FromResult(new Egg());
    }

    private static Coffee PourCoffee()
    {
        Console.WriteLine("Pouring coffee");
        return new Coffee();
    }
}

internal class Bacon
{
}

internal class Coffee
{
}

internal class Egg
{
}

internal class Juice
{
}

internal class Toast
{
}