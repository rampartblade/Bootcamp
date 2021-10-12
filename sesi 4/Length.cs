using System;

public class jagged
{
    static void Main(){
        Console.Write("Masukkan panjang angka yang diinginkan = ");
        int input = int.Parse(Console.ReadLine());
        int [] angka = new int[input];
        Console.WriteLine($"panjang angka adalah {angka.Length}");
        for (int i = 0; i < angka.Length; i++){
            angka[i] = i*i;
        }

        Console.WriteLine("Berikut adalah array angka ");
        for(int i = 0; i < angka.Length; i++){
            Console.Write(angka[i] +" ");
        }
    }
}