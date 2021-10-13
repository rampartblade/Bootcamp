using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            pesawat pesawat = new pesawat();
            pesawat_tempur pesawatmpr = new pesawat_tempur();

            pesawat.nama = "Helly";
            pesawat.roda = 3;
            pesawat.ketinggian = "1000 kaki";
            pesawat.penumpang = "3 penumpang";
            pesawatmpr.nama = "AZ500TPU";
            pesawatmpr.roda = 5;
            pesawatmpr.ketinggian = "200 kaki";
            pesawatmpr.penumpang = "2 penumpang";

            pesawat.terbang();
            pesawatmpr.terbangtinggi();
            Console.Read();
        }
    }
}
