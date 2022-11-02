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
    // 1.Write a program to show the use of public Access Modifier in c#
    // Ex:
    // Input:
    // Details of student
    // Studentid, StudentName
    // Output :
    // Studentid: 101
    // StudentName: "santhi"
    Student student1 = new Student();
    student1.StudentId = 101;
    student1.StudentName = "santhi";
    Console.WriteLine($"Student Id is : {student1.StudentId}");
    Console.WriteLine($"Student Name is : {student1.StudentName}");

    // 3. Write a program on private access modifier in c#
    student1.SetStudentFee(16);
    Console.WriteLine($"Student Fee is : {student1.GetStudentFee()}");

    // 4. Write a program on default access modifier in c#
    student1.SetClassName("MathClass");
    Console.WriteLine($"Class Name is : {student1.GetClassName()}");


}




class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }

    string  className { get; set; }
    

    //3. Write a program on private access modifier in c#
    // private field:
    private int studentFee = 3;

    //3. Write a program on private access modifier in c#
    public void SetStudentFee(int fee)
    {
        this.studentFee = fee;
    }
    public int GetStudentFee()
    {
        return this.studentFee;
    }


    //4. Write a program on default access modifier in c#
    public void SetClassName(string Classname)
    {
        this.className = Classname;
    }
    public string GetClassName()
    {
        return this.className;
    }

    protected string x { get; set; }
    // Write a program on protected access modifier using one method in c#
    // Ex:
    // Input:
    // Enter value of x
    // Output :
    // 10
    protected void InputValue()
    {
        Console.WriteLine("Enter Value of X");
        x= Console.ReadLine();
        Console.WriteLine($"{x}");
    }
   
}




