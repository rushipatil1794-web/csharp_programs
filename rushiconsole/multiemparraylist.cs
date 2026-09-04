//using System;
//using System.Collections;
//using System.Collections;
//using System.Text;

//namespace rushiconsole
//{
//    internal class multiemparraylist
//    {
//        public static void Main(string[] args)
//        {
//            ArrayList ls = new ArrayList();
//            Console.WriteLine("Store Multiple Employe");
//            Console.WriteLine("Enter Employe Count");
//            int emp_count = int.Parse(Console.ReadLine());
//            int i = 0;
//            while (i < emp_count)
//            {
//                Console.WriteLine("Enter Employe Id :");
//                int empid = int.Parse(Console.ReadLine());
//                if (ls.Contains(empid))
//                {
//                    Console.WriteLine("Employee ID already exists!");
//                    i--;
//                }
//                else
//                {
//                    Console.WriteLine("Enter Employe Name :");
//                    string empname = Console.ReadLine();
//                    Console.WriteLine("Enter Employe Department :");
//                    string dept = Console.ReadLine();
//                    Console.WriteLine("Enter Employe Salary :");
//                    double empsalary = double.Parse(Console.ReadLine());

//                    ls.Add(empid);
//                    ls.Add(empname);
//                    ls.Add(dept);
//                    ls.Add(empsalary);

//                }
//                i++;
//            }
           
//            Console.WriteLine("Employee Details Added Successfully.");
//            Console.WriteLine("____________________________________");
//            Console.WriteLine("Print Empolye Details :");
//            for (int a = 0; a < ls.Count; a++)
//            {
//                Console.WriteLine(ls[a]);
//            }
//        }
//    }
//}
