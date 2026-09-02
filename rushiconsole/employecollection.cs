//using System;
//using System.Collections;
//using System.Text;

//namespace rushiconsole
//{
//    internal class employecollection
//    {
//        public static void Main(string[] args)
//        {

//            Console.WriteLine("This is an Employee collection example.");
//            Console.WriteLine("Enter Employe Id :");
//            int emp_id = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Employe Name :");
//            string emp_name = Console.ReadLine();
//            Console.WriteLine("Enter Employe Department :");
//            string department = Console.ReadLine();
//            Console.WriteLine("Enter Employe Salary :");
//            double emp_salary = double.Parse(Console.ReadLine());
//            ArrayList al = new ArrayList();
//            al.Add(emp_id);
//            al.Add(emp_name);
//            al.Add(department);
//            al.Add(emp_salary);
//            Console.WriteLine("Employee Details Added Successfully.");

//            Console.WriteLine("_____________________________________");
//            Console.WriteLine("Print Empolye Details :");
//            for (int i = 0; i < al.Count; i++)
//            {
//                Console.WriteLine(al[i]);
//            }


//        }
//    }
//}
