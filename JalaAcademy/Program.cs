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

    // 1.Construct a class using any methods for employee details using its parameters and print
    // Output.
    Employee newEmployee = new Employee(1);
    //2.Write a program using overloading class constructor
    newEmployee.AddEmployee("Sale Department", "KK");
    newEmployee.AddEmployee("DD", "123456", "IT Department", "DD");

    // 4. Create an object of the Car class, with the name myObj. Then we print the value of
    // the fields color and maxSpeed.
    Car myObj = new Car();
    myObj.ColorOfCar = "Green";
    myObj.MaxSpeed = 200;
    Console.WriteLine($"Color of the Car is : {myObj.ColorOfCar}");
    Console.WriteLine($"Max Speed of the Car is : {myObj.MaxSpeed}");

    // 5. Write a program on creating multiple objects of one class in c#
    Car car1 = new Car();
    Car car2 = new Car();
    car1.ColorOfCar = "Blue";
    car1.MaxSpeed = 150;
    car2.ColorOfCar = "Red";
    car2.MaxSpeed = 250;
    Console.WriteLine($"Color of Car 1 is : {car1.ColorOfCar}");
    Console.WriteLine($"Color of Car 2 is : {car2.ColorOfCar}");
}


class Employee
{
    private int _empId;
    private string _loginName;
    private string _password;
    private string _name;
    private string _department;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string LoginName
    {
        get { return _loginName; }
        set { _loginName = value; }
    }
    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }
    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }
    public int EmployeeID
    {
        get { return _empId; }
    }

    public Employee(int empId)
    {
        if (empId == 1)
        {
            _empId = 1;
            LoginName = "A";
            Password = "123456";
            Name = "A";
            Console.WriteLine($"Employee {_empId} is created");
        }
        else if (empId == 2)
        {
            _empId = 2;
            LoginName = "B";
            Password = "123456";
            Name = "B";
            Console.WriteLine($"Employee {_empId} is created");
        }
    }

    public void Login(string loginName,string password)
    {
        if (loginName == "A" && password == "123456")
        {
            _empId = 1;
            Name = "A";
            Console.WriteLine("Input correct Id and password");
        }
        else
        {
            Console.WriteLine("Input wrong Id and Password");
        }
    }

    public int AddEmployee(string loginName, string password, string department, string name)
    {
        _empId = 3;
        LoginName = loginName;
        Password = password;
        Department = department;
        Name = name;
        return EmployeeID;
    }

    public int AddEmployee(string department, string name)
    {
        
        _empId = 3;
        Department = department;
        Name = name;
        return EmployeeID;
    }
}

    //3. Create a Car class with three class members and two fields and one method in c#
class Car
{
    private string colorOfCar;
    private int maxSpeed;
    public string ColorOfCar
    {
        get { return colorOfCar; }
        set { colorOfCar = value; } 
    }
    public int MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    public void Run()
    {
        Console.WriteLine("The car is moving");
    }
}




