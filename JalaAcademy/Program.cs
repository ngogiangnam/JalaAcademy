// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
{
    int empID;
    string empName;
    empID = 5;
    Console.WriteLine($"Value of EmpId is : {empID}");
    empName = "Puja";
    Console.WriteLine($"Value of empName is : {empName}");
    Console.WriteLine($"Input a number");
    var a = Console.ReadLine();
    int number = Convert.ToInt32(a.ToString());
    if (number == null)
    {
        Console.WriteLine("Please input right number");
    }
    else
    {
        if (CheckOdd(number))
        {
            Console.WriteLine($"{number} is Even");
        }
        else
        {
            Console.WriteLine($"{number} is Odd");
        }

    }
    int value1 = 22;
    int value2 = 65;
    Console.WriteLine($"Input  {value1},{value2}");
    Swap<int>(ref value1, ref value2);
    Console.WriteLine($"Output  {value1},{value2}");
}

bool CheckOdd(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
        
}

void Swap<T>(ref T a, ref T  b)
{
    T temp = a;
    a = b;
    b = temp;
}