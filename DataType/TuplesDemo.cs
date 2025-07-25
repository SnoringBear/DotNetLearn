﻿namespace DotNetLearn.DataType;

[TestFixture]
public class TuplesDemo
{
    [Test]
    public void Test01()
    {
        (double, int) t1 = (4.5, 3);
        Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
        // Output:
        // Tuple with elements 4.5 and 3.

        (double Sum, int Count) t2 = (4.5, 3);
        Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
        // Output:
        // Sum of 3 elements is 4.5.
    }
}