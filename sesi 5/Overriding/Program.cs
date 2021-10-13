using System;

namespace Overriding
{
    class Program
    {
        public int bilangan1, bilangan2;
        public void bilangan(int angka1, int angka2){
            bilangan1 = angka1;
            bilangan2 = angka2;
        }

        public virtual void penjumlahanperkalian(){
            Console.WriteLine("Overiding 1....------>>>>>");
            Console.WriteLine($"Hasil penjumlahan angka{bilangan1} dan {bilangan2} adalah {bilangan1+bilangan2}");
            Console.WriteLine($"Hasil perkalian angka {bilangan1} dan {bilangan2} adalah {bilangan1*bilangan2}");
        }
    }

    class Override:Program{
        public override void penjumlahanperkalian()
        {
            Console.WriteLine("Overiding 2....------>>>>>");
            Console.WriteLine($"Hasil penjumlahan angka{bilangan1} dan {bilangan2} adalah {bilangan1+bilangan2}");
            Console.WriteLine($"Hasil perkalian angka {bilangan1} dan {bilangan2} adalah {bilangan1*bilangan2}");            
        }    
        static void Main(string[] args)
        {
            Program overiding = new Program();
            overiding.bilangan(10, 5);
            overiding.penjumlahanperkalian();
            overiding = new Override();
            overiding.bilangan(20,5);
            overiding.penjumlahanperkalian();
            Console.Read();
        }
    }
}
