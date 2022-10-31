// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
{

    // 1. Declare a value as int datatype and print in the output
    int  intValue = 100;
    Console.WriteLine($"Value of Int Type is : {intValue}");

    // 2.Write a program in boolean type and print in console
    bool boolValue = true;
    Console.WriteLine($"Value of Boolean Type is : {boolValue}");

    //3.Write a program on converting Float to Decimal type and print in console

    float floatValue = 1/3f;
    decimal decimalValue = Convert.ToDecimal(floatValue);
    Console.WriteLine($"Convert Float Value : {floatValue} to Decimal is : {decimalValue}");


    // 4. Write a C# Sharp program that takes two numbers as input and perform an
    //operation (+,-,*,x,/) on them and displays the result of that operation.
    //Input : first number: 20, second number: 12
    //Output : 20-12 = 8
    //Output: Hello firstname lastname
    Console.WriteLine("Enter first Number");
    string firstNumberString = Console.ReadLine();
    int firstNumber = Convert.ToInt32(firstNumberString);
    Console.WriteLine("Enter second Number");
    string secondNumberString = Console.ReadLine();
    int secondNumber = Convert.ToInt32(secondNumberString);
    Console.WriteLine($"Output: {firstNumber} - {secondNumber} = {Sub(firstNumber,secondNumber)} ");

    // 5. Write a C# Sharp program that takes three letters as input and display them in Reverse Order.
    //Ex: Input: Enter letter: b Enter letter: a Enter letter: t
    //Output : t a b

    string b;
    string t;
    string a;
    Console.WriteLine("Enter letter");
    b= Console.ReadLine();
    Console.WriteLine("Enter letter");
    a = Console.ReadLine();
    Console.WriteLine("Enter letter");
    t = Console.ReadLine();
    Console.WriteLine($"Output {t} {a} {b}");

    // 6. Write a C# Sharp program that takes a character as input and check the input 
    //(lowercase) is a vowel, a digit, or any other symbol.
    //Ex: Input : symbol : a
    //Output : It is a lowercase vowel
    Console.WriteLine("Input character");
    string characterString = Console.ReadLine();
    if (Char.IsLower(characterString[0]))
    {
        Console.WriteLine("It is a lowercase symbol");
    }
    else
    {
        Console.WriteLine("It is a uppercase symbol");
    }
    
}

int Add(int a, int b)
{
    return a + b;
}
int Sub(int a,int b)
{
    return a - b;
}
