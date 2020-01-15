using System;
using System.IO;

namespace FileRead_Write_B
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                //var path = @"H:\Dev-Skill\Review\CSharpReCoded\File_A.txt";
                var path = @"H:\DEV-SKILL\Review\CSharpReCoded\File_A.txt";
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
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadLine();

        }
    }
}
