using System;

public class Logika1
{
    static void Main(string[] args){
        int a;
        int b;

        Console.Write("Masukkan nilai a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai b = ");
        b = int.Parse(Console.ReadLine());
        if(a > b){
            Console.WriteLine("nilai a lebih besar dari nilai b");
        }
        else if(a == b){
            Console.WriteLine("nilai a sama dengan b");
        }
        else if(a < b){
            Console.WriteLine("nilai a lebih kecil dari b");
        }
    }
}