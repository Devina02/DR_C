﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'k':
                            {
                                SqlConnection conn = null;
                                string strKoneksi = "Data source = LAPTOP-DP3PQGGM\\DEPIIII; " +
                                    "database=Rumahh_Sakitt; User ID = rara; password = rara123";
                                conn = new SqlConnection(string.Format(strKoneksi, db, user, pass));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. Melihat seluruh data");
                                        Console.WriteLine("2. Tambah data");
                                        Console.WriteLine("3. Keluar");
                                        Console.Write("\nEnter your choice (1-3) : ");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("DATA RUMAH SAKIT\n");
                                                    Console.WriteLine();
                                                    pr.baca(conn);
                                                    conn.close();
                                                    Console.WriteLine("Tekan enter untuk melanjutkan");
                                                    Console.ReadLine();
                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Dokter\n");
                                                    Console.Write("Masukkan ID Dokter : ");
                                                    string id_d = Console.ReadLine();
                                                    Console.Write("Masukkan Nama depan  : ");
                                                    string Nmadpn_d = Console.ReadLine();
                                                    Console.Write("Masukkan nama belakang : ");
                                                    string Nmablk_d = Console.ReadLine();
                                                    Console.Write("Masukkan gelar: ");
                                                    string glr = Console.ReadLine();
                                                    Console.Write("Masukkan spesialisasi dokter : ");
                                                    string spld = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insert(id_d, Nmadpn_d, Nmablk_d, glr, spld);
                                                        conn.Close();
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki akses untuk menambah data");
                                                        Console.WriteLine("Tekan enter untuk melanjutkan.");
                                                        Console.ReadLine();
                                                    }
                                                }
                                                break;
                                            case '3':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Pasien\n");
                                                    Console.Write("Masukkan ID_pasien : ");
                                                    string id_p = Console.ReadLine();
                                                    Console.Write("Masukkan ID Dokter : ");
                                                    string id_dp = Console.ReadLine();
                                                    Console.Write("Masukkan Nama depan  : ");
                                                    string Nmadpn_p = Console.ReadLine();
                                                    Console.Write("Masukkan nama belakang : ");
                                                    string Nmablk_p = Console.ReadLine();
                                                    Console.Write("Masukkan Tanggal datang: ");
                                                    string tgl_dt = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insert(id_p, id_dp, Nmadpn_p, Nmablk_p, tgl_dt);
                                                        conn.Close();
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki akses untuk menambah data");
                                                        Console.WriteLine("Tekan enter untuk melanjutkan.");
                                                        Console.ReadLine();
                                                    }
                                                }
                                                break;
                                        }
                                        
                                    }

                                }
                            }
                    }
                }
            }
        }
    }
}
