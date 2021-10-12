using System;
public class Soal3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Number : ");
            int n = int.Parse(Console.ReadLine());
            int hasil = 1;
            int i = n;
            Console.Write($"{n}! = ");
            // for(int i = 1; i<=n; i++){
            //     hasil = hasil * i;
            //     Console.Write($"{i} x ");
            // }
            while (n >= 1)
            {
                hasil = hasil * n;
                n--;
                if (n > 1){
                    Console.Write($"{n} x ");
                }
                else if(n == 1){
                    Console.Write("1");
                }
            }
            
            Console.WriteLine();
            Console.Write($"factorial {i} is {hasil}"); 
        }
    }
}
