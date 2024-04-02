sing System;

public class Employee
{
    
    public int EmployeeID { get; }
    public string FullName { get; set; }
    public double Salary { get; private set; }

    public Employee(int employeeID, string fullName, double salary)
    {
        EmployeeID = employeeID;
        FullName = fullName;
        Salary = salary;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Salary: ${Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Employee emp = new Employee(101, "John Doe", 50000);

        Console.WriteLine($"Employee ID: {emp.EmployeeID}");

        emp.FullName = "Jane Smith";
        Console.WriteLine($"Updated Full Name: {emp.FullName}");

        emp.DisplayEmployeeInfo();
    }
}