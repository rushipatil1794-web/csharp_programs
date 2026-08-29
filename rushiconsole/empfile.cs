//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class empwrite
//    {
//        public void task_write(int empId, string empName,string empdesignation,string education,double empSalary)
//        {
//        FileStream fs = new FileStream("C:\\Users\\Public\\employe.txt", FileMode.OpenOrCreate);
//        StreamWriter sw = new StreamWriter(fs);
//        sw.WriteLine($"Employee ID: {empId}");
//        sw.WriteLine($"Employee Name: {empName}");
//        sw.WriteLine($"Employee Designation: {empdesignation}");
//        sw.WriteLine($"Employee Education: {education}");
//        sw.WriteLine($"Employee Salary: {empSalary}");
//        sw.Close();
//        fs.Close();
//        }
//    }
//    class empread : empwrite
//    {
//        public void task_read()
//        {
//            FileStream fs = new FileStream("C:\\Users\\Public\\employe.txt", FileMode.Open);
//            StreamReader sr = new StreamReader(fs);
//            string line = sr.ReadToEnd();
//            Console.WriteLine(line);
//            sr.Close();
//            fs.Close();
//        }
//    }
//    internal class empfile:empread
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Employee Information");
//            Console.WriteLine("--------------------");
//            Console.WriteLine("Enter Employee ID:");
//            int empId=int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Employee Name:");
//            string empName=Console.ReadLine();
//            Console.WriteLine("Enter Employee Designation:");
//            string empdesignation=Console.ReadLine();
//            Console.WriteLine("Enter Employee Education:");
//            string education=Console.ReadLine();
//            Console.WriteLine("Enter Employee Salary:");
//            double empSalary= double.Parse(Console.ReadLine());
//            empfile ef = new empfile();
//            ef.task_write(empId, empName, empdesignation, education, empSalary);
//            ef.task_read();
//        }
//    }
//}
