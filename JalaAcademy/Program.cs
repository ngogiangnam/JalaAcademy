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

    // 1.Write a program to Implicit Type Conversion
    // Ex:
    // Input:
    // Enter Int value
    // Enter Long value
    // Output:
    // Int value -53
    // Long value -53
    int intValue = -53;
    long longValue = intValue;
    Console.WriteLine($"Int Value : {intValue}");
    Console.WriteLine($"Long Value : {longValue}");


    // 2.Write an example of explicit type conversion
    // Ex:
    // Input:
    // Enter Value of I
    // Output:
    // Value of I is 34

    double numDouble = 34.12;
    int numInt = (int)numDouble;
    Console.WriteLine($"value of Int is {numInt}");


    // 3.Write a program of built in type conversion methods
    // Ex:
    // Input:
    // Enter string name
    // Enter Integer value
    // Output :
    // string to float -34.6
    // int to double -337

    Console.WriteLine($"Enter string name");
    var a = Console.ReadLine();
    Console.WriteLine($"Enter Integer value");
    var b = Console.ReadLine();
    float floatValue = Convert.ToSingle(a.ToString());
    double doubleValue = Convert.ToDouble(b.ToString());
    Console.WriteLine($"string to float {floatValue}");
    Console.WriteLine($"int to double {doubleValue}");


    // 4.Write a program that converts various value types to string type
    // Ex:
    // Input:
    // Enter Integer value
    // Enter Float Value
    // Output:
    // int.ToString() - 75
    // float.ToString() - 43.09
    int c = - 75;
    float d = -43.09f;
    Console.WriteLine($"int.ToString() {c.ToString()}");
    Console.WriteLine($"float.ToString() {d.ToString()}");

}

