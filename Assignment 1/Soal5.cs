using System;
public class Soal5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            string number = Console.ReadLine();
            int temp = number.Length;
            string[] words =
            {
                "one","two","three","four","five","six","seven","eight","nine"
            };
            Console.Write("The result is : ");
            for(int i = 0; i < temp; i++)
            {
                if(number[i] == '1')
                {
                    Console.Write($"{words[0]} ");
                }
                if(number[i] == '2')
                {
                    Console.Write($"{words[1]} ");
                }
                if(number[i] == '3')
                {
                    Console.Write($"{words[2]} ");
                }
                if(number[i] == '4')
                {
                    Console.Write($"{words[3]} ");
                }
                if(number[i] == '5')
                {
                    Console.Write($"{words[4]} ");
                }
                if(number[i] == '6')
                {
                    Console.Write($"{words[5]} ");
                }
                if(number[i] == '7')
                {
                    Console.Write($"{words[6]} ");
                }
                if(number[i] == '8')
                {
                    Console.Write($"{words[7]} ");
                }
                if(number[i] == '9')
                {
                    Console.Write($"{words[8]} ");
                }
            }
        }
    }
}
