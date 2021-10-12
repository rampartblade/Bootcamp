using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string fname, lname;
            int umur;
            Console.Write("enter your first name : ");
            fname = Console.ReadLine();
            Console.Write("enter your last name : ");
            lname = Console.ReadLine();
            Console.Write("enter your age : ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine("your name is \t : "+fname+" "+lname);
            Console.WriteLine("your age \t : "+umur);
        }
        /*
        Masukkan nama depan, belakang, umur, alamat, tanggal lahir
        */
    }
}
