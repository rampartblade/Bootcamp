using System;

public class HitungLuas
{
    public static void Main(string[] args){
        int panjang = 2;
        double lebar = 2.3;
        Console.WriteLine("Hitung luas persegi panjang");
        Console.WriteLine("Luas = P x L");
        Console.WriteLine($"Luas = {panjang} x {lebar}");        
        Console.WriteLine("Luas = " +panjang*lebar);        
    }
}