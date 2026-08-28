using System;
using System.Collections.Generic;
using System.Text;

namespace rushiconsole
{
    class read
    {
        public void task_read()
        {
            FileStream fs = new FileStream("C:\\Users\\Public\\rushi.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line=sr.ReadToEnd();
            Console.WriteLine(line);
            sr.Close();
            fs.Close();

        }
    }
    class write: read
    {
        public void task_write()
        {
            FileStream fs = new FileStream("C:\\Users\\Public\\rushi.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is a sample text written to the file.");
            sw.WriteLine("You can write multiple lines of text.");
            sw.Close();
            fs.Close();
        }
    }
    internal class filehandling:write
    {
        
        public static void Main(string[] args)
        {
            // call without inheritance
            //write w = new write();
            //w.task_file();
            // call with inheritance
            filehandling fh = new filehandling();
            fh.task_write();
            fh.task_read();
            //string Path = "C:\\Users\\Public\\rushi.txt";
            //// Write to a file
            //File.Create(Path);
            //// file open
            //if(File.Exists(Path))
            //{
            //    Console.WriteLine("File is created");

            //}
            //else
            //{
            //    Console.WriteLine("File is not created");
            //}
            ////delete operation
            //string location = "C:\\Users\\Public\\rushikesh";
            //if(File.Exists(location))
            //{
            //    File.Delete(location);
            //    Console.WriteLine("File is deleted");
            //}
            //else
            //{
            //    Console.WriteLine("File is not deleted ");
            //    File.Create(location);
            //}
        }
    }
}
