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
using System.Xml.Linq;
{
    //4. Create an object for the above EmployeeModel and assign the values to all properties and print each property on console
    EmployeeModel employee = new EmployeeModel();
    employee.EmpId = 1;
    employee.EmpName = "Nam1";
    employee.EmailId = "ngogiangNam90@gmail.com";
    employee.Salary =60.5f;
    employee.IsEmployeeActive = true;
    Console.WriteLine($"Employee Id number is: {employee.EmpId}");
    Console.WriteLine($"Employee Name  is: {employee.EmpName}");
    Console.WriteLine($"Employee Email is: {employee.EmailId}");
    Console.WriteLine($"Employee Id number so {employee.Salary}");
    Console.WriteLine($"Employee is still active is : {employee.IsEmployeeActive}");

    // 5.Create another object for the above EmployeeModel and assign different values to all properties and print each property on console
    EmployeeModel employee1 = new EmployeeModel();
    employee1.EmpId = 2 ;
    employee1.EmpName = "Nam2";
    employee1.EmailId = "ngogiangNam90@gmail.com";
    employee1.IsEmployeeActive = true;
    Console.WriteLine($"Employee Id number is: {employee1.EmpId}");
    Console.WriteLine($"Employee Name  is: {employee1.EmpName}");
    Console.WriteLine($"Employee Email is: {employee1.EmailId}");
    Console.WriteLine($"Employee Id number so {employee1.Salary}");
    Console.WriteLine($"Employee is still active is : {employee1.IsEmployeeActive}");


}


class Employee
{
    // 1. Write a program on illustrating the read-only property by taking as class Employee in c#
    public readonly string idName ="1";

    //2. Write a program on both read and write property using get and set accessories in c#
    private string name;
    public string Name
    {
    get
    {
            return name;
        }
        set
        {
        name = value;
        }
    }
}

// 3. Create a class with name EmployeeModel with 5 properties EmpId int, EmpName string, EmailId string, Salary float, IsEmployeeActive bool
class EmployeeModel
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmailId { get; set; }
    public float Salary { get; set; }
    public bool IsEmployeeActive { get; set; }
}




