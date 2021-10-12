using System;

public class Logika8
{
    static void Main(string[] args){
        Console.Write("Masukkan Nilai awal : ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Masukkan Nilai akhir : ");
        int batas = int.Parse(Console.ReadLine());
        Console.Write("Pengulangan : ");
        int pengulangan = int.Parse(Console.ReadLine());
        int n = 1;
        int temp = 0;
        Console.WriteLine("=== Operator ===");
        Console.WriteLine("1. Penjumlahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");             
        Console.Write("Select Action : ");
        int count = int.Parse(Console.ReadLine());

        while (i<=batas)
        {
            Console.WriteLine("i ke-{0} = {1}", n,i);
            Console.WriteLine("sesudah");
            switch (count)
             {
                 case 1:{
                    temp = i + pengulangan;
                    Console.WriteLine("i ke-{0} = {1}", n,temp);
                    break;
                 }
                 case 2:{
                    temp = i - pengulangan;
                    Console.WriteLine("i ke-{0} = {1}", n,temp);
                    break;
                 }
                 case 3:{
                    temp = i * pengulangan;
                    Console.WriteLine("i ke-{0} = {1}", n,temp);
                    break;
                 }
                 case 4:{
                    temp = i / pengulangan;
                    Console.WriteLine("i ke-{0} = {1}", n,temp);
                    break;
                 }
                 default:{
                     Console.WriteLine("input salah");
                     break;
                 }
             } 
            n++;
            i++;

        }
    }

}