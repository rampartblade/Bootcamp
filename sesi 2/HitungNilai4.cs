using System;
public class HitungNilai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Password : ");
            string password = Console.ReadLine();

            if(age > 18 && password =="OCBC")
            {
                Console.WriteLine("WELCOME TO THE CLUB!");
            }
            else if(age<=18 && password != "OCBC")
            {
                Console.WriteLine("SORRY, TRY AGAIN!");
            }
            else
            {
                Console.WriteLine("SORRY, TRY AGAIN!");
            }
        }
    }
}
