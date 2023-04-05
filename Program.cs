using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.WriteLine("Koneksi Ke DataBase\n");
                    Console.Write("Masukkan User ID : ");
                    string user = Console.ReadLine();
                    Console.Write("Masukkan Password : ");
                    string pass = Console.ReadLine();
                    Console.Write("Masukkan DataBase tujuan : ");
                    string db = Console.ReadLine();
                    Console.Write("\nKetik K untuk koneksi ke DataBase : ");
                }
            }
        }
    }
}
