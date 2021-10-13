using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            Console.Write("Masukkan merk laptop \t: ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukkan kapasitas ram \t: ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Masukkan kapasitas memory \t: ");
            laptop1.memory = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMerk laptop adalah {laptop1.merk}");
            Console.WriteLine($"\nKapasitas ram ada {laptop1.ram}");
            Console.WriteLine($"\nKapasitas memory ada {laptop1.memory}");

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
