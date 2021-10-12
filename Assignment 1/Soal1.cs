using System;
public class Soal1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] abjad = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
                int count = 0;
                int counter = 0;
                Console.Write("Berapa range abjad yang diinginkan(Gunakan huruf sebagai acuan banyak baris)?");
                int input = int.Parse(Console.ReadLine());
                for(int i = 1; i<= input; i++){
                    for(int n = 1; n <=input; n++)
                    {
                        if(i <= input - n)
                        {
                            Console.Write(" ");
                        }
                        else 
                        {
                            Console.Write(abjad[counter]);
                            counter++;
                        }
                    }
                    while(count >= 1){
                    Console.Write(abjad[count - 1]);
                    count--;
                    }
                count = counter;
                counter = 0;
                Console.WriteLine();
            }
        }
    }
}
