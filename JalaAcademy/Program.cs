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

    // 1.Write the program to demonstrate the working of Binary Arithmetic Operators ?
    // Ex:
    // Input:
    // Enter a and b values and result to perform operations on(+, -, *,/,%)
    // Output:
    // Addition Operator: 15 Subtraction Operator: 5 Multiplication Operator: 50 Division Operator: 2 Modulo Operator: 0
    int  a = 10, b = 5, res;
    Console.WriteLine($"a = {a}, b = {b}");
    res = a + b;
    Console.WriteLine($"Addition Operator: {res}");
    res = a - b;
    Console.WriteLine($"Subtraction Operator: {res}");
    res = a * b;
    Console.WriteLine($"Multiplication Operator: {res}");
    res = a / b;
    Console.WriteLine($"Division Operator: {res}");
    res = a % b;
    Console.WriteLine($"Modulo Operator: {res}");

    // 2.Write the program to demonstrate the working of Unary Arithmetic Operators?
    // Ex:
    // Input:
    // Enter a value and res to perform operations on(a++, a--, ++a, --a)
    // Output:
    // a is 11 and res is 10 a is 10 and res is 11 a is 11 and res is 11 a is 10 and res is 10
    a = 10;
    res = a++;
    Console.WriteLine($"a is {a} and res is {res}");
    res = a--;
    Console.WriteLine($"a is {a} and res is {res}");
    res = ++a;
    Console.WriteLine($"a is {a} and res is {res}");
    res = --a;
    Console.WriteLine($"a is {a} and res is {res}");

    // 3.Write the program to demonstrate the working of Relational Operators?
    // Ex:
    // Input:
    // Enter a and b values and result to perform operations on(==,>,<,>=,<=,!=)
    // Output:
    // Equal to Operator: False Greater than Operator: False Less than Operator: True Greater than or Equal to: False Lesser than or Equal to: True Not Equal to Operator: True
    a = 5; 
    b = 10;
    Console.WriteLine($"Equal to Operator: {a == b}");
    Console.WriteLine($"Greater than Operator:: {a > b}");
    Console.WriteLine($"Less than Operator: {a < b}");
    Console.WriteLine($"Greater than or Equal to: {a >= b}");
    Console.WriteLine($"Lesser than or Equal to: {a <= b}");
    Console.WriteLine($"Not Equal to Operator: {a != b}");
}

