using System;

public class Logika2
{
    static void Main(string[] args){
        Console.Write("Masukkan Nama : ");
        string nama = Console.ReadLine();
        Console.Write("Masukkan nilai : ");
        int nilai = int.Parse(Console.ReadLine());
        Console.WriteLine("=== Data Nilai ===");
        Console.WriteLine("Nama \t: "+nama);
        Console.WriteLine("Nilai \t: "+nilai);
        if(nilai < 60){
            Console.WriteLine("Nilai kamu C");
        }
        else if(nilai < 80){
            Console.WriteLine("Nilai kamu B");
        }
        else
        {
            Console.WriteLine("Nilai kamu A");
        }
    }
}