//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class sm
//    {
//        public static void Main(string[] args)
//        {
//            sm1();
//            check_digit();
//            check_vowel();
//        }

//        static void contains()
//        {
//            string str = "I Love My Date Of Birth 19 09 2004";
//            string match = "Date";
//            bool match_str = false;
//            for (int i = 0; i < str.Length; i++)
//            {
//               if()
//            }
           
//        }
//        static void check_vowel()
//        {
//            string vowel = "";
//            string str = "I Love My Date Of Birth 19 09 2004";
//            bool found = false;
//            for (int i = 0; i < str.Length; i++)
//            {
//                if (str[i] >= 'A' || str[i] <= 'a' || str[i] <= 'E' || str[i] <= 'e' || str[i] <= 'I' || str[i] <= 'i' || str[i] <= 'O' || str[i] <= 'o' || str[i] <= 'U' || str[i] <= 'u')
//                {
//                    found = true;
//                    vowel= vowel + str[i];
//                }
//            }
//            if (found)
//            {
//                Console.WriteLine("this string found vowel :" + vowel +" ");
//            }
//            else
//            {
//                Console.WriteLine("this string not found vowel");
//            }
//        }
//        static void check_digit()
//        {
//            string digit = "";
//            string str = "I Love My Date Of Birth 19 09 2004";
//            bool found = false;
//            for (int i = 0; i < str.Length; i++)
//            {
//                if (str[i] >= '0' && str[i] <= '9')
//                {
//                    found = true;
//                    digit= digit + str[i];
//                }
//            }
//            if (found)
//            {
//                Console.WriteLine("this string found digits :"+ digit +" ");
//            }
//            else
//            {
//                Console.WriteLine("this string not found digits:");
//            }
//        }
//        static void sm1()
//        {
//            string str = "I Love .Net Framework";
//            Console.WriteLine(str);
//            Console.WriteLine("equals:" + str.Equals("i love fortune cloud"));
//            Console.WriteLine("substring:" + str.Substring(8));
//            Console.WriteLine("replece:" + str.Replace("I", "You"));
//            Console.WriteLine("tolower:" + str.ToLower());
//            Console.WriteLine("contains:" + str.Contains("Love"));
//            Console.WriteLine("toupper:" + str.ToUpper());
//            Console.WriteLine("trim:" + str.Trim());
//            Console.WriteLine("length:" + str.Length);
//            Console.WriteLine("remove:" + str.Remove(7));
//            char[] chars = str.ToCharArray();
//            for (int i = 0; i < chars.Length; i++)
//            {
//                Console.Write(chars[i]);
//            }
//            Console.WriteLine();
//            Console.WriteLine("after modification of string is :" + str);
//        }
//    }
//}
