// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
{

    //1.Write a program using WriteLine(Boolean) method in c#
    bool isTrue = true;
    Console.WriteLine(isTrue);


    // 2. Write a program on static and instance methods in c#
    Car.Run();
    Car car = new Car();
    car.Engine();

    // 3.Write a method of Calculator and print sum and product in c#
    // Ex:
    // Input:
    // enter a and b values
    // Output :
    // sum = 12 and product = 36
    Console.WriteLine($"Input a number");
    var a = Console.ReadLine();
    int number1 = Convert.ToInt32(a.ToString());
    Console.WriteLine($"Input b number");
    var b = Console.ReadLine();
    int number2 = Convert.ToInt32(b.ToString());
    Console.WriteLine($"sum = {Sum(number1,number2)} and product = {Product(number1, number2)}");

    // 4.Write a program using parameter arrays and print output in console in c#
    int[] array = new int[5] { 1, 2, 3, 4, 5 };
    Console.WriteLine("Print Array");
    PrintArray(array);

    // 5.Write a program to print entered number of even numbers in c#
    // Ex:
    // Input:
    // Enter number : 5
    // Output:
    // 2 4 6 10 12
    Console.WriteLine();
    Console.WriteLine($"Enter Number");
    var c = Console.ReadLine();
    int number3 = Convert.ToInt32(a.ToString());
    PrintEvenNumber(number3);

}

void PrintArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintEvenNumber(int n)
{
    for (int i =1; i <=n; i++)
    {
        Console.Write(i * 2);
    }
}

 int Sum(int a, int b)
{
    return a + b;
}

int Product (int a, int b)
{
    return a * b;
}

class Car
{
    
    public static void Run()
    {
        Console.WriteLine("It is static method");
    }
    public void Engine()
    {
        Console.WriteLine("It is instance method");
    }
}





