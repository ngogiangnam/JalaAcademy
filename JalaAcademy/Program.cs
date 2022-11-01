// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
{
    // 1. Define a program on overloading by changing the Number of parameters.
    A classA = new A();
    classA.Display(1);
    classA.Display(1, 2);

    // 2. Define a program on changing the order of parameters using method overloading.
    classA.Identity(1, "Nam1");
    classA.Identity("Nam2", 2);

    // 3. Define a program on a function Sum() that accepts values as a parameter and print their addition.
    int[] array1 = new int[6] { 1, 2, 3, 4, 5, 6 };
    int sum1 = classA.Sum(array1);
    Console.WriteLine($"Sum int values = {sum1}");
    double[] array2 = new double[6] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
    double sum2 = classA.Sum(array2);
    Console.WriteLine($"Sum double values  = { sum2}");

    //  4. Define a program on a function Division() that accepts multiple values as a parameter and print their divisor.


}


class A
{
    public void Display(int a)
    {
        Console.WriteLine($"1 parameter displayed");
    } 

    public void Display(int a, int b)
    {
        Console.WriteLine($"2 parameters displayed");
    }
    public void Identity(String name, int id)
    {

        Console.WriteLine("Name1 : " + name + ", "
                        + "Id1 : " + id);
    }

    public void Identity(int id, String name)
    {

        Console.WriteLine("Name2 : " + name + ", "
                        + "Id2 : " + id);
    }

    public int Sum(int[] intValueArray)
    {
        int sum = 0;
        for (int i = 0; i < intValueArray.Length; i++)
        {
            sum = sum + intValueArray[i];
        }
        return sum;
    }
    public double Sum(double[] intValueArray)
    {
        double sum = 0;
        for (int i = 0; i < intValueArray.Length; i++)
        {
            sum = sum + intValueArray[i];
        }
        return sum;
    }

}




