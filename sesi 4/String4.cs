using System;

public class String3
{
    static void Main(){
        string str = "C# membuat string mudah";
        
        Console.Write("pilih start kata ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("pilih end kata ");
        int end = int.Parse(Console.ReadLine());
        string substr = str.Substring(start,end);

        Console.WriteLine($"String awal : {str}");
        Console.WriteLine($"Substring : {substr}");
        Console.WriteLine($"Substring : {str.Length}");

    }
}