// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    // 1. Create a datatable object
    DataTable workTable = new DataTable();

    // 2. Create a datatable object with a name by using constructor
    DataTable jalaTable = new DataTable("Jala");

    // 3. Write any 10 properties of DataTable
    // IsInitialized
    // HasErrors
    // DataSet
    // Namespace
    // CaseSensitive
    // TableName
    // PrimaryKey
    // DefaultView
    // MinimumCapacity
    // Prefix


    // 4. Write any 10 method of DataTable
    // Import, EndLoadData, GetErrors, NewRow, Load , LoadDataRow, GetChanges, OnRemoveColumn, OnRowDeleted, OnTableCleared


    // 5. Add 4 columns(EmpId, EmpName, Emp Salary, Department) to this data table object using columns.add() method.
    jalaTable.Columns.Add("EmpId");
    jalaTable.Columns.Add("EmpName");
    jalaTable.Columns.Add("Emp Salary");
    jalaTable.Columns.Add("Department");

    // 6. Add 5 records to this datatable object using Rows.Add() method.

    DataRow row1;
    row1 = jalaTable.NewRow();
    row1["EmpId"] = 1;
    row1["EmpName"] = "A";
    row1["Emp Salary"] = "1000";
    row1["Department"] = "A Department";
    jalaTable.Rows.Add(row1);

    DataRow row2;
    row2 = jalaTable.NewRow();
    row2["EmpId"] = 1;
    row2["EmpName"] = "B";
    row2["Emp Salary"] = "2000";
    row2["Department"] = "B Department";
    jalaTable.Rows.Add(row2);

    DataRow row3;
    row3 = jalaTable.NewRow();
    row3["EmpId"] = 3;
    row3["EmpName"] = "C";
    row3["Emp Salary"] = "1500";
    row3["Department"] = "C Department";
    jalaTable.Rows.Add(row3);

    DataRow row4;
    row4 = jalaTable.NewRow();
    row4["EmpId"] = 4;
    row4["EmpName"] = "D";
    row4["Emp Salary"] = "2000";
    row4["Department"] = "D Department";
    jalaTable.Rows.Add(row4);

    DataRow row5;
    row5 = jalaTable.NewRow();
    row5["EmpId"] = 5;
    row5["EmpName"] = "E";
    row5["Emp Salary"] = "3000";
    row5["Department"] = "E Department";
    jalaTable.Rows.Add(row5);

    // 7. Print the EmpId column of this datatable using for loop
    for (int i = 0; i < jalaTable.Rows.Count; i++)
    {
        Console.Write($"{jalaTable.Rows[i]["EmpId"]} "); 
    }
    Console.WriteLine();

    // 8. Print the EmpId column of this datatable using foreach loop
    foreach (DataRow row in jalaTable.Rows)
    {
        Console.Write($"{row["EmpId"]} ");
    }

    // 9. Print the EmpId column of this datatable using DataRow property

    // 10.Create another datatable with 5 columns(Your choice) and 4 records.
    DataTable carTable = new DataTable("Car");
    carTable.Columns.Add("Name");
    carTable.Columns.Add("Color");
    carTable.Columns.Add("Price");
    carTable.Columns.Add("Speed");
    carTable.Columns.Add("IsAuto");

    DataRow rowCar1;
    rowCar1 = carTable.NewRow();
    rowCar1["Name"] = "Car 1";
    rowCar1["Color"] = "Green";
    rowCar1["Price"] = "100000";
    rowCar1["Speed"] = "300";
    rowCar1["IsAuto"] = false;
    carTable.Rows.Add(rowCar1);

    DataRow rowCar2;
    rowCar2 = carTable.NewRow();
    rowCar2["Name"] = "Car 2";
    rowCar2["Color"] = "Blue";
    rowCar2["Price"] = "200000";
    rowCar2["Speed"] = "400";
    rowCar2["IsAuto"] = true;
    carTable.Rows.Add(rowCar2);

    DataRow rowCar3;
    rowCar3 = carTable.NewRow();
    rowCar3["Name"] = "Car 3";
    rowCar3["Color"] = "Red";
    rowCar3["Price"] = "150000";
    rowCar3["Speed"] = "300";
    rowCar3["IsAuto"] = false;
    carTable.Rows.Add(rowCar3);

    DataRow rowCar4;
    rowCar4 = carTable.NewRow();
    rowCar4["Name"] = "Car 4";
    rowCar4["Color"] = "Black";
    rowCar4["Price"] = "200000";
    rowCar4["Speed"] = "350";
    rowCar4["IsAuto"] = false;
    carTable.Rows.Add(rowCar4);

    // 11. Create a DataSet object
    DataSet dataSet = new DataSet();

    // 12. Create a DataSet object with name 'MyDataSet' using its constructor
    DataSet dataSetOject = new DataSet("MyDataSet");

    // 13.Add above two datatables to MyDataSet DataSet using Tables.Add() method
    dataSetOject.Tables.Add(jalaTable);
    dataSetOject.Tables.Add(carTable);

    // 14. Write any 3 Properties of ArrayList
    // IsSynchronized,IsFixedSize, Count, Capacity

    // 15. Write any 3 methods of ArrayList
    // AddRange, IndexOf ,Insert

    // 16.Difference between Array and Arraylist
    // Array is static.	ArrayList is dynamic and can be modified the size whenever needed.
    // Array  can either be single-dimensional or multidimensional.  ArrayList can be only single-dimensional 
    //  Array is faster than ArrayList due to its static behaviour.ArrayList is slower as compared to the Array due to its dynamic behaviour.

    // 17.Create a Arraylist and add 3 string elements 'One' , 'Two' , 'Three' by using add method
    ArrayList arrayList = new ArrayList();
    arrayList.Add("One");
    arrayList.Add("Two");
    arrayList.Add("Three");

    Console.WriteLine();
    // 18. Print the above arraylist element using for and foreach loop
    foreach (var item in arrayList)
    {
        Console.Write($"{item}  ");
    }

    Console.WriteLine();
    // 19. Remove all the elements in the ArrayList using Clear method
    arrayList.Clear();

    // 20. Reverse all the elements in the ArrayList using Reverse method
    arrayList.Add("One");
    arrayList.Add("Two");
    arrayList.Add("Three");
    arrayList.Reverse();
    foreach (var item in arrayList)
    {
        Console.Write($"{item}  ");
    }
    Console.WriteLine();

    // 21. Sort all the elements in the ArrayList using Sort method
    arrayList.Sort();
    foreach (var item in arrayList)
    {
        Console.Write($"{item}  ");
    }
}



