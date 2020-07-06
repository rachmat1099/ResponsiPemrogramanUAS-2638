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
                        Console.WriteLine("Maaf, Menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            //Console.WriteLine
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");


            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection

            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.WriteLine("\nKode Produk    : ");
            produk.kode_produk = Console.ReadLine();
            Console.WriteLine("Nama Produk  : ");
            produk.kode_produk = Console.ReadLine();
            Console.WriteLine("Harga Beli   : ");
            produk.harga_beli = double.Parse(Console.ReadLine());
            Console.WriteLine("Harga Jual   : ");
            produk.harga_jual = double.Parse(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

            Console.Clear();
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Produk");
            Console.WriteLine("Kode Produk");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk) ;
            {
                no++;
                if (produk.kodeproduk == kode)
                {
                    hapus = no;
                }
            }
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection

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
