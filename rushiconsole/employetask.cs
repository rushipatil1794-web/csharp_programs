using System;
using System.Collections.Generic;
using System.Text;

namespace rushiconsole
{
    internal class employetask
    {
        public static void Main(string[] args)
        {
            string Path = "C:\\Users\\Public\\rushiemp.txt";
            // Write to a file
            File.Create(Path).Close();
            // file open
            if (File.Exists(Path))
            {
                Console.WriteLine("File is created");
                Console.WriteLine("Enter Employee ID:");
                int empId= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();
                Console.WriteLine("Enter Employee Designation:");
                string empdesignation = Console.ReadLine();
                Console.WriteLine("Enter Employee Education:");
                string education = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                double empSalary = double.Parse(Console.ReadLine());
                //File.WriteAllLines(Path, new string[] {
                //    $"Employee ID: {empId}",
                //    $"Employee Name: {empName}",
                //    $"Employee Designation: {empdesignation}",
                //    $"Employee Education: {education}",
                //    $"Employee Salary: {empSalary}"
                //});
                //File.WriteAllText(Path, $"Employee ID: {empId}\nEmployee" +
                //                        $" Name: {empName}" +
                //                        $"\nEmployee Designation: {empdesignation}" +
                //                        $"\nEmployee Education: {education}" +
                //                        $"\nEmployee Salary: {empSalary}");
                File.WriteAllText(Path, "Employee ID:"+ empId+
                                        "\nEmployee Name: " + empName + 
                                        "\nEmployee Designation: " + empdesignation + 
                                        "\nEmployee Education: " + education + 
                                        "\nEmployee Salary: " + empSalary);
                
                string read = File.ReadAllText(Path);
                Console.WriteLine(read);
            }
            else
            {
                Console.WriteLine("File is not created");
            }

           
        }
    }
}
