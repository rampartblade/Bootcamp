using System;

public class String3
{
    static void Main(){
        string[] str1 = {"ini", "adalah", "sebuah", "test"};
        Console.WriteLine("Array Asli : ");

        for(int i = 0; i < str1.Length; i++){
            Console.Write(str1[i] + " ");
        }

        Console.WriteLine("\n");

        str1[1] = "merupakan";
        str1[3] = "test, juga !";
        Console.WriteLine("Array Termodifikasi");
        for(int i = 0; i < str1.Length; i++){
            Console.Write(str1[i] + " ");
        }
     }
}