using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        string num1 = "1234567890";
        string num2 = "9876543210";

        BigInteger result = BigInteger.Parse(num1) * BigInteger.Parse(num2);

        Console.WriteLine($"The result of multiplying {num1} and {num2} is: {result}");
    }
}