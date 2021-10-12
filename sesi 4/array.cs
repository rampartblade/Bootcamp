using System;

public class array
{
    static void Main(string[] args){
        string [] contoh = new string [4]
        {
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };
        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");

        foreach (string contoh1 in contoh)
        {
            Console.WriteLine(contoh1);
        }
    }
}