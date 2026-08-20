using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace rushiconsole
{
    class strarray //parent class
    {
        string name = "Rushikesh Patil";
        public void rev_str()
        {
            string temp = "";
            for(int i=name.Length-1; i>=0; i-- )
            {
                temp=temp+name[i];
            }
            Console.WriteLine("Rushikesh Patil Reverse Is:"+temp);
        }
    }
    class strarray2 : strarray //child class of strarray
    {
        public void check_con()
        {
            string msg = "welcome";
            char[] m = msg.ToCharArray();
            bool check = false;
            for (int i = 0; i < msg.Length; i++)
            {
                for (int j = i + 1; j < msg.Length; j++)
                {
                    if (msg[i] == m[j])
                    {
                        check = true;
                    }
                }
            }
            if(check==true)
            {
                Console.WriteLine("e is present in "+msg);
            }
            else
            {
                Console.WriteLine("e is not present in"+msg);
            }
        }
    }
    class twodarray: strarray2 // child class of strarray2
    {
        public void twoarray()
        {
            int[,] number =
            {
                {10,11,12,13,14,15,16,17,18,19,20},
                {21, 22, 23, 24, 25, 26, 27, 28, 29,30,31 }
            };
            for(int i = 0;i < number.GetLength(0);i++)
            {
                for(int j = 0;j < number.GetLength(1);j++)
                {
                    Console.WriteLine(number[i,j]);
                }
            }
        }
    }
    class stratrangle: strarray // child class ofstrarray
    {
        public void star()
        {
            for( int i = 0;i<=10;i++)
            {
                for(int j = 0;j<=i;j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class hybridtask
    {
        public static void Main(string[] args)
        {
            twodarray t=new twodarray();
            t.rev_str();//call parent class
            t.check_con(); //call child class
            t.twoarray();//call sub child class
            Console.WriteLine("___________________________");
            stratrangle s=new stratrangle();
            s.rev_str();//call parent class
            s.star();//call child class
        }
    }
}
