using System;
using System.Collections;

namespace rushiconsole
{
    class Employee
    {
        public int Id;
        public string Name;
        public string department;
        public double Salary;

        public void addEmployee(int id, string name, double salary, string department)
        {
            Id = id;
            Name = name;
            Salary = salary;
            this.department = department;
        }
    }

    internal class Class1
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            while (true)
            {
                Console.WriteLine("\n=================== Employee Management =====================");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employees");
                Console.WriteLine("3. Search Employee");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("5. Remove Employee");
                Console.WriteLine("6. Sort by Salary");
                Console.WriteLine("7. Highest Salary");
                Console.WriteLine("8. Employee Count");
                Console.WriteLine("9. Search Employee by Department");
                Console.WriteLine("10. Clear All Employees");
                Console.WriteLine("11. Exit");
                Console.WriteLine("==============================================================");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    // 1. Add Employee
                    case 1:
                        Console.Write("Enter Employee ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Employee Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Employee Salary: ");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Employee Department: ");
                        string department = Console.ReadLine();

                        Employee emp = new Employee();

                        emp.addEmployee(id, name, salary, department);

                        list.Add(emp);

                        Console.WriteLine("Employee added successfully.");
                        break;


                    // 2. Display Employees
                    case 2:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No employees found.");
                            break;
                        }

                        Console.WriteLine("\nDisplaying Employees:");

                        foreach (Employee emp1 in list)
                        {
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("Employee ID: " + emp1.Id);
                            Console.WriteLine("Employee Name: " + emp1.Name);
                            Console.WriteLine("Employee Salary: " + emp1.Salary);
                            Console.WriteLine("Employee Department: " + emp1.department);
                        }

                        break;


                    // 3. Search Employee
                    case 3:
                        Console.Write("Enter Employee ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;

                        foreach (Employee emp1 in list)
                        {
                            if (emp1.Id == searchId)
                            {
                                Console.WriteLine("\nEmployee Found:");
                                Console.WriteLine("Employee ID: " + emp1.Id);
                                Console.WriteLine("Employee Name: " + emp1.Name);
                                Console.WriteLine("Employee Salary: " + emp1.Salary);
                                Console.WriteLine("Employee Department: " + emp1.department);

                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee not found.");
                        }

                        break;


                    // 4. Update Employee
                    case 4:
                        Console.Write("Enter Employee ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        bool updateFound = false;

                        foreach (Employee emp1 in list)
                        {
                            if (emp1.Id == updateId)
                            {
                                Console.WriteLine("\nEmployee Found:");

                                Console.WriteLine("Current Name: " + emp1.Name);
                                Console.Write("Enter New Name: ");
                                emp1.Name = Console.ReadLine();

                                Console.WriteLine("Current Salary: " + emp1.Salary);
                                Console.Write("Enter New Salary: ");
                                emp1.Salary = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Current Department: " + emp1.department);
                                Console.Write("Enter New Department: ");
                                emp1.department = Console.ReadLine();

                                updateFound = true;

                                Console.WriteLine("Employee updated successfully.");
                                break;
                            }
                        }

                        if (!updateFound)
                        {
                            Console.WriteLine("Employee not found.");
                        }

                        break;


                    // 5. Remove Employee
                    case 5:
                        Console.Write("Enter Employee ID to remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());

                        Employee removeEmployee = null;

                        foreach (Employee emp1 in list)
                        {
                            if (emp1.Id == removeId)
                            {
                                removeEmployee = emp1;
                                break;
                            }
                        }

                        if (removeEmployee != null)
                        {
                            list.Remove(removeEmployee);
                            Console.WriteLine("Employee removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }

                        break;


                    // 6. Sort by Salary
                    case 6:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No employees found.");
                            break;
                        }

                   

                        ArrayList sortedList = new ArrayList();

                        while (sortedList.Count < list.Count)
                        {
                            Employee lowest = null;

                            foreach (Employee emp1 in list)
                            {
                                bool alreadyAdded = false;

                                foreach (Employee sortedEmp in sortedList)
                                {
                                    if (sortedEmp == emp1)
                                    {
                                        alreadyAdded = true;
                                        break;
                                    }
                                }

                                if (!alreadyAdded)
                                {
                                    if (lowest == null || emp1.Salary < lowest.Salary)
                                    {
                                        lowest = emp1;
                                    }
                                }
                            }

                            sortedList.Add(lowest);
                        }

                        list.Clear();

                        foreach (Employee emp1 in sortedList)
                        {
                            list.Add(emp1);
                        }

                        Console.WriteLine("\nEmployees sorted by Salary:");

                        foreach (Employee emp1 in list)
                        {
                            Console.WriteLine(
                                "ID: " + emp1.Id +
                                ", Name: " + emp1.Name +
                                ", Salary: " + emp1.Salary +
                                ", Department: " + emp1.department
                            );
                        }

                        break;


                    // 7. Highest Salary
                    case 7:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No employees found.");
                            break;
                        }

                        Employee highestEmployee = null;

                        foreach (Employee emp1 in list)
                        {
                            if (highestEmployee == null ||
                                emp1.Salary > highestEmployee.Salary)
                            {
                                highestEmployee = emp1;
                            }
                        }

                        Console.WriteLine("\nHighest Salary Employee:");
                        Console.WriteLine("Employee ID: " + highestEmployee.Id);
                        Console.WriteLine("Employee Name: " + highestEmployee.Name);
                        Console.WriteLine("Employee Salary: " + highestEmployee.Salary);
                        Console.WriteLine("Employee Department: " + highestEmployee.department);

                        break;


                    // 8. Employee Count
                    case 8:
                        Console.WriteLine("Total Employee Count: " + list.Count);
                        break;


                    // 9. Search by Department
                    case 9:
                        Console.Write("Enter Employee Department to search: ");
                        string searchDepartment = Console.ReadLine();

                        bool departmentFound = false;

                        foreach (Employee emp1 in list)
                        {
                            if (emp1.department == searchDepartment)
                            {
                                Console.WriteLine("\nEmployee Found:");
                                Console.WriteLine("Employee ID: " + emp1.Id);
                                Console.WriteLine("Employee Name: " + emp1.Name);
                                Console.WriteLine("Employee Salary: " + emp1.Salary);
                                Console.WriteLine("Employee Department: " + emp1.department);

                                departmentFound = true;
                            }
                        }

                        if (!departmentFound)
                        {
                            Console.WriteLine("Employee not found in this department.");
                        }

                        break;


                    // 10. Clear All Employees
                    case 10:
                        list.Clear();

                        Console.WriteLine("All Employees Cleared.");
                        break;


                    // 11. Exit
                    case 11:
                        Console.WriteLine("Exiting Employee Management System.");
                        return;


                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}