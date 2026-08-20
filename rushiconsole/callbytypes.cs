//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class callbytypes
//    {
//        public static void Main(string[] args)
//        {
//            int org_num = 56;
//            Console.WriteLine("----------- CALL BY VALUE -----------");
//            Console.WriteLine("Before Modification Number Is:"+org_num);
//            cbv(org_num);
//            Console.WriteLine("After Modification Number Is:" + org_num);
//            Console.WriteLine("----------- CALL BY REFERENCE -----------");
//            Console.WriteLine("Before Modification Number Is:" + org_num);
//            cbr(ref org_num);
//            Console.WriteLine("After Modification Number Is:" + org_num);
//        }
//        static void cbv(int no)
//        {
//            no = 45;
//        }
//        static void cbr(ref int no)
//        {
//            no = 12;
//        }
//    }
//}
