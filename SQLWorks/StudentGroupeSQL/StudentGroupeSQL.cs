using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroupeSQL
{
    class StudentGroupeSQL
    {
        static void Main(string[] args)
        {
            tableAdmin();
        }
        static void tableAdmin()
        {
            string msg = "table";
            int n = -1;
            while (n != 0)
            {
                Console.Clear();
                Console.WriteLine("\tАдминистриране на базата данни\t");
                Console.WriteLine("===========================");
                Console.WriteLine("1 ==> Създаване на таблица");
                Console.WriteLine("2 ==> Изтриване на таблица");
                Console.WriteLine("0 ==> Изход от менюто");
                Console.WriteLine("===========================");
                Console.Write("Изберете опция =>");
                n = int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("1 ==> Създаване на таблица");
                        break;
                    case 2:
                        Console.WriteLine("1 ==> Изтриване на таблица");
                        break;
                }
                Console.WriteLine("Натиснете някакъв клавиш!");
                Console.ReadKey();
            }
        }
    }
}
