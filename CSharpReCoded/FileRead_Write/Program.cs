using System;
using System.IO;

namespace FileRead_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            // file read operation 
            //try
            //{
            //    StreamReader sr = new StreamReader(@"E:\Dev-Skill\Review\CSharpReCoded\demo_file_read.txt");
            //    var line = sr.ReadLine();
            //    while (line != null)
            //    {
            //        Console.WriteLine(line);
            //        line = sr.ReadLine();
            //    }
            //    sr.Close();
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            // file write operation

            try
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                //currentDirectory = @"..\..\..\.."+ currentDirectory;
                var path = @"H:\DEV-SKILL\Review\CSharpReCoded\demo_file_read.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("File Write 1");
                        sw.WriteLine("File Write 2");
                        Console.WriteLine("File Created and write");
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (sr.ReadLine() != null)
                        {
                            Console.WriteLine(sr.ReadLine());
                            sr.ReadLine();
                        }
                        sr.Close();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadKey();
        }
    }
    
}
