using System;
public class Soal6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Palindrome Check ===");
            Console.Write("Enter Word : ");
            int temp = 0;
            string kata = Console.ReadLine();
            char [] word = new char[kata.Length];
            bool check = true;
            int count = kata.Length - 1;
            while (count >= 0 && check)
            {
                word[temp] = kata[count];
                if(word[temp] == kata[temp])
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                count--;
                temp++;
            }
            if(check)
            {
                Console.WriteLine("word is a palindrome");
            }
            else
            {
                Console.WriteLine("word is not a palindrome");
            }
        }
    }
}
