using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($".NET version: {RuntimeInformation.FrameworkDescription}");
    }
}