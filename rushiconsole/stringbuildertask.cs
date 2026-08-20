//using System;

//namespace rushiconsole
//{
//    internal class stringbuildertask
//    {
//        public static void Main(string[] args)
//        {
//            stringbuildertask sb = new stringbuildertask();
//            sb.revers_string();
//            Console.WriteLine();
//            Console.WriteLine("____________________________");
//            contains();
//            Console.WriteLine();
//            Console.WriteLine("____________________________");
//            check_duplicate();
//        }
//        static void check_duplicate()
//        {
//            string state = "Maharashtra";
//            char[] name = state.ToCharArray();

//            char dupchar = '\0';
//            bool isdup = false;
//            int count = 0;

//            for (int i = 0; i < name.Length; i++)
//            {
//                for (int j = i + 1; j < name.Length; j++)
//                {
//                    if (name[i] == name[j])
//                    {
//                        isdup = true;
//                        count++;
//                        dupchar = name[i];

//                        Console.WriteLine("Duplicate character: " + dupchar);
//                    }
//                }
//            }

//            Console.WriteLine("Duplicate found: " + isdup);
//            Console.WriteLine("Duplicate count: " + count);
//        }
//        static void contains()
//        {
//            Console.WriteLine("enter string");
//            string name = Console.ReadLine();
//            Console.WriteLine("enter character");
//            char ch = char.Parse(Console.ReadLine());
//            bool ispresent = false;
//            char[] letters = name.ToCharArray();
//            for (int i = 0; i < letters.Length; i++)
//            {
//                if (letters[i] == ch)
//                {
//                    ispresent = true;
//                }
//            }
//            if (ispresent = true)
//            {
//                Console.WriteLine(ch + " " + "is contains in " + name);
//            }
//            else
//            {
//                Console.WriteLine(ch + "is not contains in " + name);
//            }

//        }

//        void revers_string()
//        {
//            string name = "Muskan";
//            int length = name.Length;

//            for (int i = length - 1; i >= 0; i--)
//            {
//                Console.Write(name[i]);
//            }
//        }
//    }
//}