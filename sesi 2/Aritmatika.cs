using System;

public class Aritmatika
{
    static void Main(string[] args){
        Console.WriteLine("===Menghitung Nilai===");
        Console.Write("Masukkan Nilai Pertama : ");
        int nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Masukkan Nilai Kedua : ");
        int nilai2 = int.Parse(Console.ReadLine());        
        Console.Write("Masukkan Nilai Ketiga : ");
        int nilai3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Total Nilai adalah : "+ (nilai1+nilai2+nilai3));
        Console.WriteLine("Rata Rata Nilai adalah : "+ (nilai1+nilai2+nilai3)/3);        
    }
}