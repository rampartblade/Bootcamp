using System;

public class Hitung4
{
    static void Main(string[] args){
        Console.Write("Jumlah Nilai 1 = ");
        int nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Jumlah Nilai 2 = ");
        int nilai2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Hasil Perbandigan : ");
        Console.WriteLine($"nilai1 > nilai2 : {nilai1 > nilai2}");
        Console.WriteLine($"nilai1 >= nilai2 : {nilai1 >= nilai2}");
        Console.WriteLine($"nilai1 < nilai2 : {nilai1 < nilai2}");
        Console.WriteLine($"nilai1 <= nilai2 : {nilai1 <= nilai2}");
        Console.WriteLine($"nilai1 == nilai2 : {nilai1 == nilai2}");
        Console.WriteLine($"nilai1 != nilai2 : {nilai1 != nilai2}");
    }
}