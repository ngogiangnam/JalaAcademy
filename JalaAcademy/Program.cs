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
    // 1. Write a program on A class has two methods with the same name "Add" but with
    // different input parameters (the first method has three parameters and the second
    // method has two parameters) in c#
    A classA = new A();
    Console.WriteLine($"4 + 3 +2  = {classA.Add(4, 3, 2)}");
    Console.WriteLine($"4 + 3  = {classA.Add(4, 3)}");

    //2. Write a program on Runtime polymorphism in c#

    Users baseClass = new Users();
    baseClass.GetInfo();
    Details derivedClass = new Details();
    derivedClass.GetInfo();

    // 3. Write a program on taking one method with same but different signature in the methods in c#
    classA.DoTask(2);
    classA.DoTask("2");

    // 4. Write a program to demonstrate the function overloading by changing the Data types of the parameters in c#
    int sum1 = classA.Add(1, 2, 3);
    Console.WriteLine($"Sum of the three int type = {sum1}");
    double sum2 = classA.Add(1.0, 2.0, 3.0);
    Console.WriteLine($"Sum of the three double type = {sum2}");

    //5. Write a program to demonstrate the function overloading by changing the Order of the parameters in c#
    classA.Identity(1, "Nam1");
    classA.Identity("Nam2",2);

}


class A
{
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a,double b, double c)
    {
        return a + b + c; ;
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    public void DoTask(int id)
    {
        Console.WriteLine($"Task ID is {id}");
    }
    public void DoTask(string idString)
    {
        Console.WriteLine($"Task ID is {idString}");
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
}

// Base Class
public class Users
{
    public virtual void GetInfo()
    {
        Console.WriteLine("Base Class");
    }
}
// Derived Class
public class Details : Users
{
    public override void GetInfo()
    {
        Console.WriteLine("Derived Class");
    }
}



