using System;

public class TipeString
{
    static void Main(string[] args){
        string nama;
        string alamat;
        int umur;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukkan Nama : \t");
        nama = Console.ReadLine();
        Console.Write("Masukkan Alamat : \t");
        alamat = Console.ReadLine();
        Console.Write("Masukkan Umur : \t");
        umur = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Terima Kasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama \t: {nama}");
        Console.WriteLine($"Alamat \t: {alamat}");
        Console.WriteLine($"Umur \t: {umur}");
        Console.WriteLine("SUDAH DISIMPAN ! ");
    }
}