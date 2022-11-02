// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Data;
{
    // 1.Create a list of employee objects with properties EmpId, EmpName, EmpSalary and DeptId add 10 employee objects to the above list
    List<Employee> employees = new List<Employee>();

    Employee employee1 = new Employee()
    {
        EmpId = 1,
        EmpName = "kishore",
        EmpSalary = 3000,
        DeptId = 1,
    };
    employees.Add(employee1);

    Employee employee2 = new Employee()
    {
        EmpId = 2,
        EmpName = "kishore",
        EmpSalary = 2000,
        DeptId = 4,
    };
    employees.Add(employee2);

    Employee employee3 = new Employee()
    {
        EmpId = 3,
        EmpName = "A",
        EmpSalary = 1000,
        DeptId = 2,
    };
    employees.Add(employee3);

    Employee employee4 = new Employee()
    {
        EmpId = 4,
        EmpName = "B",
        EmpSalary = 1000,
        DeptId = 2,
    };
    employees.Add(employee4);

    Employee employee5 = new Employee()
    {
        EmpId = 5,
        EmpName = "C",
        EmpSalary = 4000,
        DeptId = 5,
    };
    employees.Add(employee5);

    Employee employee6 = new Employee()
    {
        EmpId = 6,
        EmpName = "D",
        EmpSalary = 5000,
        DeptId = 7,
    };
    employees.Add(employee6);

    Employee employee7 = new Employee()
    {
        EmpId = 7,
        EmpName = "E",
        EmpSalary = 5000,
        DeptId = 9,
    };
    employees.Add(employee7);

    Employee employee8 = new Employee()
    {
        EmpId = 8,
        EmpName = "F",
        EmpSalary = 7000,
        DeptId = 7,
    };
    employees.Add(employee8);

    Employee employee9 = new Employee()
    {
        EmpId = 9,
        EmpName = "G",
        EmpSalary = 3000,
        DeptId = 8,
    };
    employees.Add(employee9);

    Employee employee10 = new Employee()
    {
        EmpId = 10,
        EmpName = "H",
        EmpSalary = 1500,
        DeptId = 7,
    };
    employees.Add(employee10);


    //1. Check whether 'Kishore' employee is present in the list using select method with lambda
    //expression. and print the empid, empname, empsal and deptid of the employee object
    //print distinct objects not distinct names

    var searchEmployees = employees.Where(x => x.EmpName == "kishore").Select(s => new Employee()
    {
        EmpId = s.EmpId,
        EmpName = s.EmpName,
        EmpSalary = s.EmpSalary,
        DeptId = s.DeptId,
    });

    if (searchEmployees == null)
    {
        Console.WriteLine("There is no Kishore in the list");
    }
    else
    {
        Console.WriteLine("There is Kishore in the list");
        foreach (var employee in searchEmployees)
        {
            Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");
        }
    }

    // 2.Check whether empid = 4 employee is present in the list using select method with lambda
    // expression.and print the empid, empname, empsal and deptid of the employee object
    // print distinct objects not distinct names
    var searchIdEmployees = employees.Where(x => x.EmpId == 4).Select(s => new Employee()
    {
        EmpId = s.EmpId,
        EmpName = s.EmpName,
        EmpSalary = s.EmpSalary,
        DeptId = s.DeptId,
    });

    if (searchIdEmployees == null)
    {
        Console.WriteLine("There is no Employee with ID = 4 in the list");
    }
    else
    {
        Console.WriteLine("There is Employee with ID = 4 in the list");
        foreach (var employee in searchIdEmployees)
        {
            Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");
        }
    }

    // 3.Check whether deptid = 4 employee is present in the list using select method with lambda
    // expression.and print the empid, empname, empsal and deptid of the employee object
    // print distinct objects not distinct names
    var searchDeptIdEmployees = employees.Where(x => x.DeptId == 4).Select(s => new Employee()
    {
        EmpId = s.EmpId,
        EmpName = s.EmpName,
        EmpSalary = s.EmpSalary,
        DeptId = s.DeptId,
    });

    if (searchDeptIdEmployees == null)
    {
        Console.WriteLine("There is no Employee with Dept ID = 4 in the list");
    }
    else
    {
        Console.WriteLine("There is Employee with Dept ID = 4 in the list");
        foreach (var employee in searchDeptIdEmployees)
        {
            Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");
        }
    }

    // 4. Create another employee list and copy the above list to this newly created employee list
    List<Employee> newEmployees = new List<Employee>(employees);

    //5. Create another employee list and copy the above list with empname having Kishore and print this list
    //Note: The new list should contain only employee objects with name Kishore
    List<Employee> listEmployees = employees.Where(x => x.EmpName == "kishore").Select(s => new Employee()
    {
        EmpId = s.EmpId,
        EmpName = s.EmpName,
        EmpSalary = s.EmpSalary,
        DeptId = s.DeptId,
    }).ToList();

    if (listEmployees == null)
    {
        Console.WriteLine("There is no Kishore in the list");
    }
    else
    {
        Console.WriteLine("There is Kishore in the list");
        foreach (var employee in listEmployees)
        {
            Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");
        }
    }

    // 6.Create another employee list and copy the above list with empsalary having greater than 2000
    // and print this list count and list
    // Note: The new list should contain only employee objects with empsalary > 2000
    var searchSalaryEmployees = employees.Where(x => x.EmpSalary > 2000).Select(s => new Employee()
    {
        EmpId = s.EmpId,
        EmpName = s.EmpName,
        EmpSalary = s.EmpSalary,
        DeptId = s.DeptId,
    });

    if (searchSalaryEmployees == null)
    {
        Console.WriteLine("There is no Employee with salary greater than 2000 in the list");
    }
    else
    {
        Console.WriteLine($"There is {searchSalaryEmployees.Count()} Employee with salary greater than 2000 in the list");
        foreach (var employee in searchSalaryEmployees)
        {
            Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");
        }
    }

    // 7.Check whether deptid = 4 employee is present in the list using select method with lambda
    // expression.and print the empid, empname, empsal and deptid of the employee object
    var searchDeptId4Employees = employees.Where(x => x.DeptId == 4).Select(s => new Employee()
    {
        EmpId = s.EmpId,
        EmpName = s.EmpName,
        EmpSalary = s.EmpSalary,
        DeptId = s.DeptId,
    });

    if (searchDeptId4Employees == null)
    {
        Console.WriteLine("There is no Employee with Dept ID = 4 in the list");
    }
    else
    {
        Console.WriteLine("There is Employee with Dept ID = 4 in the list");
        foreach (var employee in searchDeptId4Employees)
        {
            Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");
        }
    }

    // 8.Check whether deptid = 4 employee is present in the list using contains method with lambda expression.and print the empid,
    // empname, empsal and deptid of the employee object
    var searchDistinctEmployees = employees.Distinct(new EmployeeNameComparer());

    if (searchDistinctEmployees == null)
    {
        Console.WriteLine("There is no Distinct Employee name in the list");
    }
    else
    {
        Console.WriteLine("There is Distinct Employee name in the list");
        foreach (var employee in searchDistinctEmployees)
        {
            Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");

        }

    }

    // 10. Create an integer array with 5 elements and convert this integer array into integer list using ToList()
    int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
    List<int> arrayList = array1.ToList();

    
    // 11. Get the first employee in the employee list using First() method
    Employee firstEmployee = employees.First();

    // 12.Get the first employee in the employee list using FirstOrDefault() method
    Employee firstOrDefaultEmployee = employees.FirstOrDefault();

    // 13. Get the first employee in the employee list using Single() method
    try
    {
        Employee singleEmployee = employees.Single();
    }
    catch (System.InvalidOperationException)
    {
        Console.WriteLine("The collection does not contain exactly one element.");
    }

    // 14. Get the first employee in the employee list using SingleOrDefault() method
    try
    {
        Employee singleOrDefaultEmployee = employees.SingleOrDefault();
    }
    catch (System.InvalidOperationException)
    {
        Console.WriteLine("The collection does not contain exactly one element.");
    }

    // 15. Sort the employee list by EmpID using OrderBy() method
    var empOrderByID = employees.OrderBy(x => x.EmpId).ToList() ;
    Console.WriteLine("Order By ID");
    foreach (var employee in empOrderByID)
    {
        Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");

    }

    // 16. Sort the employee list by EmpName using OrderBy() method
    var empOrderByName = employees.OrderBy(x => x.EmpName).ToList();
    Console.WriteLine("Order By Name");
    foreach (var employee in empOrderByID)
    {
        Console.Write($"EmpId is {employee.EmpId}, EmpName is {employee.EmpName}, Emp Salary is {employee.EmpSalary}, Emp Dept Id is {employee.DeptId} \n");
    }

 
}

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int EmpSalary { get; set; }
    public int DeptId { get; set; }
}


// Custom comparer for the Product class
class EmployeeNameComparer : IEqualityComparer<Employee>
{
    // Products are equal if their names and product numbers are equal.
    public bool Equals(Employee x, Employee y)
    {
        if (Object.ReferenceEquals(x, y)) return true;

        if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
            return false;

        return x.EmpName == y.EmpName;
    }

    // If Equals() returns true for a pair of objects
    // then GetHashCode() must return the same value for these objects.

    public int GetHashCode(Employee employee)
    {
        //Check whether the object is null
        if (Object.ReferenceEquals(employee, null)) return 0;

        int hashEmployeeName = employee.EmpName == null ? 0 : employee.EmpName.GetHashCode();

        return hashEmployeeName;
    }
}



