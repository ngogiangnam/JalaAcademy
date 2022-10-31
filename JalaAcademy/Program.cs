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

    // 1.Write a C# Sharp program to check whether a given number is positive or negative.
    // Ex:
    // Input: 14 Output: 14 is a positive number
    Console.WriteLine($"Enter a number");
    var a = Console.ReadLine();
    int number = Convert.ToInt32(a.ToString());
    if (number > 0)
    {
        Console.WriteLine($"{a} is a positive number");
    }
    else if (number < 0)
    {
        Console.WriteLine($"{a} is a negative number");
    }

    // 2.Write a C# Sharp program to find whether a given year is a leap year or not.
    // Ex:
    // Input: 2016
    // Output: 2016 is leap year

    Console.WriteLine($"Enter a year");
    var b = Console.ReadLine();
    int year = Convert.ToInt32(b.ToString());
    if (DateTime.IsLeapYear(year) )
    {
        Console.WriteLine($"{year} is leap year");
    }
    else 
    {
        Console.WriteLine($"{year} is not leap year");
    }

   // 3.Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
   // Ex:
   // Input: enter any alphabet: k
   // Output : The alphabet is a consonant.

    Console.WriteLine($"Enter any alphabet");
    var c = Console.ReadLine();
    char ch = Convert.ToChar(c.ToLower());
    int i = ch;
    if (i >= 48 && i <= 57)
    {
        Console.WriteLine("You entered a number, Please enter an alpahbet.");
    }
    else
    {
        switch (ch)
        {
            case 'a':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'i':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'o':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'u':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'e':
                Console.WriteLine("The Alphabet is vowel");
                break;
            default:
                Console.WriteLine("The Alphabet is a consonant.");
                break;
        }
    }
}

