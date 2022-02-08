using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLExample__16._12._2021_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"D:\SQLworks\SQLExample (16.12.2021)\SqlQuery\","*.sql"); //masiv
            string filename;
            string path = @"D:\SQLworks\SQLExample (16.12.2021)\SqlQuery\";
            int count = files.Length;
            string[] result = new string[count];
            int choice;
            string msg;
            Console.WriteLine("===================================");
            for (int i = 0; i < count; i++)
            {
                filename = $@"D:\SQLworks\SQLExample (16.12.2021)\SqlQuery\{files[i]}";
                result[i] =  Path.GetFileNameWithoutExtension(filename);
                Console.WriteLine($"\t{i+1}\t{result[i]}");
            }
            Console.WriteLine("====================================");
            Console.Write("Избери номера на файла => ");
            choice = int.Parse(Console.ReadLine())-1;

            try
            {
                Console.WriteLine($"Файл {result[choice]}.sql съдържа сктрипт: ");
                Console.WriteLine("====================================");
                msg = File.ReadAllText($" {path} {result[choice]}.sql");
                Console.WriteLine(msg);
                Console.WriteLine("====================================");

            }
            catch (Exception)
            {

                Console.WriteLine("Файлът не е намерен");
            }
            finally
            {
                Console.WriteLine("Натиснете някакъв клавиш!");
                Console.ReadKey();
            }
        }
    }
}
