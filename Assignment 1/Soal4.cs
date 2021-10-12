using System;
public class Soal4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            string angka = Console.ReadLine();
            int count = angka.Length - 1;
            Console.Write("Reversed number : ");
            while (count >= 0)
            {
                Console.Write(angka[count]);
                count--;
            }
        }
    }
}
