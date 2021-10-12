using System;
public class Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, nilai1, nilai2, nilai3;
            string nikah;
            bool cond;
            string password;
            string username;

            Console.Write("username : ");
            username = Console.ReadLine();

            Console.Write("password : ");
            password = Console.ReadLine();
            
            Console.Write("age : "); 
            age = int.Parse(Console.ReadLine());
            
            Console.Write("jenis kelamin : ");
            string kelamin = Console.ReadLine();
            
            Console.Write("status nikah(y/n)");
            nikah = Console.ReadLine();
            
            Console.WriteLine("=== Aritmatika ===");
            Console.Write("Nilai Pertama : ");
            nilai1 = int.Parse(Console.ReadLine());
            
            Console.Write("Nilai Kedua : ");
            nilai2 = int.Parse(Console.ReadLine());
            
            Console.Write("Nilai Ketiga : ");
            nilai3 = int.Parse(Console.ReadLine());

            if(username == "Ricky" && age > 18 && password == "OCBC")
            {
                Console.WriteLine("=== Biodata Pengguna ===");
                Console.WriteLine("username"+username);
                Console.WriteLine("umur : "+age);
                Console.WriteLine("Jenis Kelamin : "+kelamin);
                if(nikah == "y")
                {
                    cond = true;
                    Console.WriteLine("Status Nikah : "+cond);
                }
                else
                {
                    cond = false;
                    Console.WriteLine("Status Nikah : "+cond);
                }
                Console.WriteLine("=== Aritmatika ===");
                Console.WriteLine("Total Nilai adalah : "+ (nilai1+nilai2+nilai3));
                Console.WriteLine("Rata Rata Nilai adalah : "+ (nilai1+nilai2+nilai3)/3);
            }   
            else{
                Console.WriteLine("Sorry, Try Again!");
            }        
        }
    }
}
