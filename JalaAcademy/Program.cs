// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
{

    // 1. Create any value called EmpName and print that value in the output
    string empName;
    Console.WriteLine($"Input empName");
    empName = Console.ReadLine();
    Console.WriteLine($"Value of empName Output: {empName}");

    // 2.Declare a variable name of any datatype and read the name in the output
    int intType = 5;
    Console.WriteLine($"DataType of intType is {intType.GetType().Name}");
    // 3. Enter your name and from WriteLine function and print the output
    Console.WriteLine("Enter your name");
    string myName= Console.ReadLine();
    Console.WriteLine($"My name is : {myName}");

    // 4.Declare a 2 strings as input and contacenate with another string with the both Strings and get Output
    //Ex: Input : enter firstname , enter lastname , "Hello" + firstname + lastname
    //Output: Hello firstname lastname
    Console.WriteLine("Enter first name");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter last name");
    string lastName = Console.ReadLine();
    Console.WriteLine($"Hello {firstName} {lastName}");

    // 5. Write a program by taking two integer values and return the value by adding in the Output
    //Ex: Input: 5,4
    //Output : 9

    int value1 = 5;
    int value2 = 4;
    Console.WriteLine($"Input: {value1},{value2}");
    Console.WriteLine($"Output {Add(value1, value2)}");

    // 6. Write a program to enter password by converting it to char array into string print the Output
    // Ex: Input : enter password
    // Output : Password : 123
    Console.WriteLine("Enter pasword");
    string passwordString = Console.ReadLine();
    char[] passwordCharArray = passwordString.ToCharArray();
    Console.Write("Password: ");
    foreach(char ch in passwordCharArray)
    {
        Console.Write(ch);
    }
}

int Add(int a, int b)
{
    return a + b;
}
