using System;

public class HelloWorld
{
    public static void Main(string[] args){
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello Ricky");
        Console.WriteLine("Selamat datang di Program Bootcamp OCBC");
        Console.WriteLine("Tahap 1 saya akan belajar C#");

        string nama = "foxi";
        double barang1 = 10;
        double barang2 = 7;
        double barang3 = 13;
        double harga1 = 10.000;
        double harga2 = 5.000;
        double harga3 = 20.000;

        double total1 = barang1 * harga1;
        double total2 = barang2 * harga2;
        double total3 = barang3 * harga3;
        
        double totalbarang = barang1 + barang2 + barang3;
        double totalharga = total1 + total2 + total3;
        Console.WriteLine();
        Console.WriteLine("Nama Customer : \t"+nama);
        Console.WriteLine($"barang 1 berjumlah {barang1} dengan harga {harga1} yang harus dibayar {total1}");
        Console.WriteLine($"barang 2 berjumlah {barang2} dengan harga {harga2} yang harus dibayar {total2}");
        Console.WriteLine($"barang 3 berjumlah {barang3} dengan harga {harga3} yang harus dibayar {total3}");
        Console.WriteLine();
        Console.WriteLine("jumlah semua barang : "+totalbarang);
        Console.WriteLine("jumlah semua harga : "+totalharga);

        
    }
}