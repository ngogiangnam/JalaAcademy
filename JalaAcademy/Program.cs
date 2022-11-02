// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;
{
    // 1.Write any 5 Properties of List
    // 2.Write any 5 methods of List
    // 3.Create an integer list and add any 5 integers to this list
    // 4.Print the integer elements in the above list using for loop
    List<int> listInt = new List<int>();
    listInt.Add(1);
    listInt.Add(2);
    listInt.Add(3);
    listInt.Add(4);
    listInt.Add(5);
    for (int i= 0; i < listInt.Count; i++)
    {
        Console.Write($" {listInt[i]}");
    }
    Console.WriteLine();
    // 5.Print the integer elements in the above list using foreach loop
    foreach (var item in listInt)
    {
        Console.Write($" {item}");
    }

    Console.WriteLine();

    // 6. Create an string list and add any 5 integers to this list
    List<string> listString = new List<string>();
    listString.Add("A");
    listString.Add("B");
    listString.Add("C");
    listString.Add("D");
    listString.Add("E");
    // 7.Print the string elements in the above list using for loop
    for (int i = 0; i < listString.Count; i++)
    {
        Console.Write($" {listString[i]}");
    }
    Console.WriteLine();
    // 8. Print the string elements in the above list using foreach loop
    foreach (var item in listString)
    {
        Console.Write($" {item}");
    }
    Console.WriteLine();

    // 9. Count the elements in the list and print on the console
    Console.WriteLine($"Total element in the list is {listString.Count}");

    // 10. Clear all the elements in the list using clear method
    listString.Clear();

    // 11. Check whether 'Kishore' is present in the string list using exists method
    listString.Add("Kishore");
    listString.Add("B");
    listString.Add("C");
    listString.Add("D");
    listString.Add("E");
    // 11. Check whether 'Kishore' is present in the string list using exists method
    bool isExist = listString.Exists(x=>x.Equals("Kishore"));

    // 12. Check whether 'Kishore' is present in the string list using Find method
    string searchString  = listString.Find(x => x.Equals("Kishore"));

    //13  whether 'Kishore' is present in the string list using contains method
    bool isCotains =  listString.Contains("Kishore");

    //14. Insert an element into the list using Insert method
    listString.Insert(1, "A");

    // 15. Reverse the list using reverse method
    listString.Reverse();

    // 16. Remove an element at index 3 using RemoveAt method
    listString.RemoveAt(3);

    // 17.Create a list with student class (List that accepts student objects)
    List<Student> studentList = new List<Student>();
    // 18. Add 10 Student objects to the list
    studentList.Add(new Student() { Id =1, Name="A"});
    studentList.Add(new Student() { Id =2, Name="B"});
    studentList.Add(new Student() { Id =3, Name="C"});
    studentList.Add(new Student() { Id =4, Name="D"});
    studentList.Add(new Student() { Id =5, Name="E"});
    studentList.Add(new Student() { Id =6, Name="G"});
    studentList.Add(new Student() { Id =7, Name="F"});
    studentList.Add(new Student() { Id =8, Name="H"});
    studentList.Add(new Student() { Id =9, Name="L"});
    studentList.Add(new Student() { Id =10, Name="I"});

    // 19. Count the elements in the list and print on the console
    int countStudentList = studentList.Count();
    Console.WriteLine($"Total Student List is : {countStudentList}");

    // 20. Clear all the elements in the list using clear method
    studentList.Clear();

    studentList.Add(new Student() { Id = 1, Name = "A" });
    studentList.Add(new Student() { Id = 2, Name = "B" });
    studentList.Add(new Student() { Id = 3, Name = "C" });
    studentList.Add(new Student() { Id = 4, Name = "D" });
    studentList.Add(new Student() { Id = 5, Name = "E" });
    studentList.Add(new Student() { Id = 6, Name = "G" });
    studentList.Add(new Student() { Id = 7, Name = "F" });
    studentList.Add(new Student() { Id = 8, Name = "H" });
    studentList.Add(new Student() { Id = 9, Name = "L" });
    studentList.Add(new Student() { Id = 10, Name = "I" });

    // 21. Check whether 'Kishore' student is present in the list using exists method
    bool isStudentExist = studentList.Exists(x => x.Name.Equals("Kishore"));

    // 22. Check whether 'Kishore' is present in the string list using Find method
    Student searchStudent = studentList.Find(x => x.Name.Equals("Kishore"));

    //23  whether 'Kishore' is present in the string list using contains method
    Student containStudent = studentList.Where(x => x.Name.Contains("A")).FirstOrDefault();

    // 24. Insert an student object into the list using Insert method
    Student addStudent = new Student() { Id = 0, Name = "AA" };
    studentList.Insert(0, addStudent);

}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}



