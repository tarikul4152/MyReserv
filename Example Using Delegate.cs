using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        List<Employee> EMPL = new List<Employee>();
        EMPL.Add(new Employee() { ID = 001, Name = "Tarikul Islam", Salary = 10000, Experience = 21 });
        EMPL.Add(new Employee() { ID = 002, Name = "Rashedul Islam", Salary = 15000, Experience = 26 });
        EMPL.Add(new Employee() { ID = 003, Name = "Sirajul Islam", Salary = 50000, Experience = 55 });
        EMPL.Add(new Employee() { ID = 004, Name = "Rubia Akter", Salary = 10000, Experience = 45 });
        EMPL.Add(new Employee() { ID = 005, Name = "Shahanaz Parvin", Salary = 20000, Experience = 28 });
        EMPL.Add(new Employee() { ID = 006, Name = "Shah Sohel", Salary = 40000, Experience = 33 });
        EMPL.Add(new Employee() { ID = 007, Name = "Shah Ali Saad", Salary = 5000, Experience = 4 });
        EMPL.Add(new Employee() { ID = 008, Name = "Ishita Akter", Salary = 7000, Experience = 18 });

        
        //Lamda Expression
        Employee.PromoteEmployee(EMPL, emp => emp.Experience >= 5);
        
        IsPromotable isPromotable = new IsPromotable(Promote);

        Employee.PromoteEmployee(EMPL, isPromotable);

        Console.ReadKey();
    }
    public static bool Promote(Employee empl)
    {
        if (empl.Experience >= 10 && empl.Experience <= 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }
    public static void PromoteEmployee(List<Employee> EMPList,IsPromotable IsEligible)
    {
        foreach (Employee empList in EMPList)
        {
            if (IsEligible(empList))
            {
                Console.WriteLine("ID : {0} Name : {1} Salary : {2} Experience : {3}", empList.ID, empList.Name, empList.Salary, empList.Experience);
            }
        }
    }
}
