using System;
using System.Globalization;

public class String2
{
    static void Main(){
        string str1 = "Untuk pemrograman .NET, C# adalah #1.";
        string str2 = "Untuk pemrograman .NET, C# adalah #1.";
        string str3 = "string C# sangat tangguh";

        Console.WriteLine($"str 1 {str1}");
        Console.WriteLine($"panjang str 1 adalah {str1.Length}");
        Console.WriteLine($"Versi huruf kecil dari str 1 : {str1.ToLower(CultureInfo.CurrentCulture)}");
        Console.WriteLine($"Versi huruf besar dari str 1 : {str1.ToUpper(CultureInfo.CurrentCulture)}");
        Console.WriteLine("Menampilkan str1, char demi char.");
        for(int i = 0; i < str1.Length; i++){
            Console.Write(str1[i] + " ");
        }

        if(str1 == str2){
            Console.WriteLine("str 1 == str 2");
        }
        else{
            Console.WriteLine("str 1 != str 2");
        }

        if(str1 == str3){
            Console.WriteLine("str 1 == str 3");
        }
        else{
            Console.WriteLine("str 1 != str 3");
        }

        int hasil = string.Compare(str1, str3, StringComparison.CurrentCulture);
        if(hasil == 0){
            Console.WriteLine("str 1 dan str 3 sama");
        }
        else if(hasil < 0){
            Console.WriteLine("str 1 kurang dari str 3");
        }
        else
        {
            Console.WriteLine("str 1 lebih dari str 3");
        }

        str2 = "Satu Dua Tiga Satu";

        int idx  = str2.IndexOf("Satu", StringComparison.Ordinal);
        int idx2  = str2.LastIndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine($"Indeks kemunculan pertama dari satu : {idx}");
        Console.WriteLine($"Indeks kemunculan terakhir dari Satu : {idx2}");
    }
}