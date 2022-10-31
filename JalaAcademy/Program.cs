// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
{

    // 1.Write a program in C# Sharp to display n terms of natural number and their sum.
    // Ex:
    // Input:
    // Enter number of natural terms do you want
    // Output :
    // The first 7 natural number is :
    // 1 2 3 4 5 6 7
    // The Sum of Natural Number upto 7 terms: 28
    Console.WriteLine($"Enter number of natural terms do you want");
    var a = Console.ReadLine();
    int number = Convert.ToInt32(a.ToString());
    Console.WriteLine($"The first {number} natural is :");
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i} ");
        sum = sum + i;
    }
    Console.WriteLine();
    Console.WriteLine($"The Sum of Natural Number upto {number} terms : {sum}");


    // 2.Write a program in C# Sharp to display the n terms of odd natural number and their sum.
    // Ex:
    // Input:
    // Input number of terms : 10
    // Output:
    // The odd numbers are :1 3 5 7 9 11 13 15 17 19
    // The Sum of odd Natural Number upto 10 terms: 100
    Console.WriteLine($"Input number of terms");
    var b = Console.ReadLine();
    int oddnumber = Convert.ToInt32(b.ToString());
    Console.WriteLine($"The odd numbers are :");
    int oddSum= 0;
    for (int i = 1; i <= oddnumber; i++)
    {
        
        Console.Write($"{i*2-1} ");
        oddSum = oddSum + i * 2 - 1;
    }
    Console.WriteLine();
    Console.WriteLine($"The Sum of odd Natural Number upto 10 terms : : {oddSum}");


    // 3.By using Array write the program using For and Foreach loop in c#
    // Ex:
    // Input:
    // Enter Array printing using for loop
    // Enter Array printing using ForEach loop
    // Output:
    // JalaTechnologies
    // JalaTechnologies

   
    Console.WriteLine("Enter Array printing using for loop");
    string stringValue1  = Console.ReadLine();
    Console.WriteLine("Enter Array printing using ForEach loop");
    string stringValue2 = Console.ReadLine();
    char[] chArray = stringValue1.ToCharArray();
    for (int i = 0; i< stringValue1.Length; i++)
    {
        Console.Write(chArray[i]);
    }
    Console.WriteLine();

    foreach (char ch in stringValue2)
    {
        Console.Write(ch);
    }

}

