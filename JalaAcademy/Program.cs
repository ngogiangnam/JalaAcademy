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
    // 1. Define a static variable and access that through class name.
    Car.MaxSpeed = 300;
    // 2.Define a static method and access that through a instance
    Car.CarMoving();
    // 3.Define a static and instance variable constructors and invoke the instance constructor
    Car car1 = new Car("green"); // First static constructor will be called and after it will invoke intance contructor
    //4. Define a static variable and change within the class
    car1.IncreaseSpeed();
}


class Car
{
    static Car()
    {
        Console.WriteLine("Static constructor called");
    }

    // instance constructor
    public Car(string color)
    {

        Console.WriteLine("Instance constructor called");
    }
    public static int MaxSpeed;
    public static int Speed = 0;

    public static void CarMoving()
    {
        Console.WriteLine("Static Method Car Moving");
    }
    public void IncreaseSpeed()
    {
        Speed++;
    }
}




