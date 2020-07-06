using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool loop = true;
            while (loop)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            //Console.WriteLine
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("\n1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
            produk.kodeproduk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.namaproduk = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.harga_beli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.harga_jual = double.Parse(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Produk");
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if (produk.kodeproduk == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData produk berhasil di hapus");
            }else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int noUrut = 0;
            Console.WriteLine("Data Produk");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}. Kode Produk: {1}, Nama Produk: {2}, Harga Beli: {3}, Harga Jual: {4}", noUrut, produk.kodeproduk, produk.namaproduk, produk.harga_beli, produk.harga_jual);
    
        }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
