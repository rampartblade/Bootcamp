using System;

public class Logika6
{
    static void Main(string[] args){
        Console.Write("Masukkan angka  : ");
        int a = int.Parse(Console.ReadLine());
        int count = 1;
        while (a < 20)
        {
             Console.WriteLine("Nilai a = " + a);
             a++;
             count++;
        }
        Console.WriteLine($"Perulangan dilakukan sebanyak {count - 1} kali");
    }

}