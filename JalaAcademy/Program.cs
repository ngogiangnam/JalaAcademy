// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
{

    // 1. Write a Program to Reverse a String without using Reverse function
    // Ex: Enter a String : INDIA
    // Reverse String is : AIDNA

    Console.WriteLine("Enter a String");
    string stringValue = Console.ReadLine();
    char[] charArray = stringValue.ToCharArray();

    string reverseStringValue = string.Empty;
    for(int i = stringValue.Length - 1; i >= 0; i--)
    {
        reverseStringValue += charArray[i];
    }
    Console.WriteLine($"Reverse String is : {reverseStringValue}");

    // 2. Write a program in C# Sharp to find the length of a string without using library function.
    //Ex: Input: Jalatechnologies
    //Output : 16
    Console.WriteLine("Enter String to check Length");
    string checkedLengthStringValue = Console.ReadLine();
    int length = 0;
    foreach (char ch in checkedLengthStringValue)
    {
        length++;
    }
    Console.WriteLine($"Length of {checkedLengthStringValue} is : {length}");

    //3. Write a Program to calculate the length of the string using count function

    Console.WriteLine("Enter String to check Length using Count Function");
    string checkedStringValue = Console.ReadLine();
    Console.WriteLine($"Length of {checkedStringValue} is : {checkedStringValue.Length}");


    // 4. Write a Program to Replace String in String using Replace function
    //Ex: Sentence Before Replacing : Sun Rises in the West
    //Sentence After Replacing : Sun Rises in the East
    string beforeSentence = "Sun Rises in the West";
    string afterSentence = beforeSentence.Replace("West", "East");
    Console.WriteLine($"Sentence Before Replacing: {beforeSentence}");
    Console.WriteLine($"Sentence After Replacing: {afterSentence}");


    // 5.Write a Program to Convert Upper case to Lower Case using LowerCase method
    //Ex: Enter the String in Uppercase : JALA
    //String in Lowercase :jala

    
    Console.WriteLine("Enter the String in Uppercase");
    string upperCaseString= Console.ReadLine();
    Console.WriteLine($"String in Lowercase: {upperCaseString.ToLower()}");

    // 6. Write a program in C# Sharp to find maximum occurring character in a string. 
    //Ex: Input string : Welcome to india
    //Output : The highest frequency of the character 'a' appear as 1 time

    Console.WriteLine("Input String");
    string characterString = Console.ReadLine();
    int max = 0;
    char result = new char();
    int[] count = new int[256];
    
    for (int i= 0; i < characterString.Length; i++)
    {
        count[characterString[i]]++;
        if (max < count[characterString[i]])
        {
            max = count[characterString[i]];
            result = characterString[i];
        }
    }
    Console.WriteLine($"The highest freaquency of the character '{result}' appear as {max} time");

    //7. Write a program in C# Sharp to sort a string array in ascending order.
    //Ex: Input string : this is a string
    //Output : After sorting the string appears like : a g h i i i n r s s s t t
    Console.WriteLine("Input String for task 7");
    string inputString = Console.ReadLine();
    char[] charList = inputString.ToCharArray();
    char chTemp;
    for (int i= 1; i < inputString.Length; i++)
        for (int j=0; j< inputString.Length - i; j++)
        {
            if (charList[j] > charList[j+1])
            {
                chTemp = charList[j];
                charList[j] = charList[j + 1];
                charList[j + 1] = chTemp;
            }
        }
    Console.WriteLine($"After sorting the string appears like : ");
    foreach (char c in charList)
    {
        Console.Write($"{c} ");
    }
}

