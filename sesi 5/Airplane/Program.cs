using System;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            Console.Write("Masukkan nama pesawat :");
            pesawat.nama = Console.ReadLine();
            pesawat.Ketinggian = "2500 kaki";

            pesawat.terbang();
            pesawat.sudahterbang();
            Console.Read();
        }
    }
}
