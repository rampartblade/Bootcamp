using System;
public class Soal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the range = ");
            int input = int.Parse(Console.ReadLine());
            int count = 1;
            int counter = 0;
            for(int i = 1; i<= input; i++){
                for(int n = 1; n <=input; n++)
                {
                    if(i <= input - n)
                    {
                        Console.Write(" ");
                    }
                    else 
                    {
                        Console.Write(count++);
                    }
                }
                while(counter > 1){
                    Console.Write(counter - 1);
                    counter --;
                }
                counter = count;
                count = 1;
                Console.WriteLine("");
            }
        }
    }
}
