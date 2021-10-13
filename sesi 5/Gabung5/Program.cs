using System;

namespace Gabung5
{
    class Program
    {
        static void Menu(){
            Console.WriteLine("=== Sesi 5 ");
            Console.WriteLine("Nama          \t: Ricky Adiputra");
            Console.WriteLine("Nomor Peserta \t: 023");
            Console.WriteLine("Domisili      \t: Jakarta");
            Console.WriteLine("1. Pesawat Tempur");
            Console.WriteLine("2. Overloading");
            Console.WriteLine("3. Bilangan");
            Console.WriteLine("4. Tentang Saya");
            Console.WriteLine("5. Share Aplikasi");
            Console.WriteLine("6. Exit");
        }

        static void Airplane(){
                Pesawat pesawat = new Pesawat();
                Pesawat_tempur pesawatmpr = new Pesawat_tempur();
                Console.WriteLine("=== Pesawat Tempur ===");
                Console.Write("Nama pesawat 1 : ");
                pesawat.nama = Console.ReadLine();
                Console.Write("Banyak roda pesawat 1 : ");
                pesawat.roda = int.Parse(Console.ReadLine());
                Console.Write("Ketinggian pesawat 1 : ");
                pesawat.ketinggian = Console.ReadLine();
                Console.Write("Jumlah Penumpang pesawat 1 : ");
                pesawat.penumpang = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Nama pesawat 2 : ");
                pesawatmpr.nama = Console.ReadLine();
                Console.Write("Banyak roda pesawat 2 : ");
                pesawatmpr.roda = int.Parse(Console.ReadLine());
                Console.Write("Ketinggian pesawat : ");
                pesawatmpr.ketinggian = Console.ReadLine();
                Console.Write("Jumlah penumpang pesawat 2 : ");
                pesawatmpr.penumpang = Console.ReadLine();

                pesawat.terbang();
                pesawatmpr.terbangtinggi();
                Console.ReadKey();
        }

        static void Overloading(){
            overloading overloading = new overloading();
            Console.WriteLine("=== Overloading ===");
            Console.Write("Nama \t: ");
            overloading.nama = Console.ReadLine();
            Console.Write("Nomor telepon \t: ");
            overloading.nomor = int.Parse(Console.ReadLine());
            overloading.print(overloading.nama);
            overloading.print(overloading.nomor);
            Console.ReadKey();
        }

        static void Bilangan(){
            overriding overriding = new overriding();
            Console.WriteLine("=== Bilangan ===");
            Console.Write("Masukkan bilangan 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            overriding.bilangan(num1,num2);
            overriding.penjumlahanperkalian();
            overriding = new overiding();
            Console.Write("Masukkan bilangan 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan 2 : ");
            num2 = int.Parse(Console.ReadLine());
            overriding.bilangan(num1,num2);
            overriding.penjumlahanperkalian();
            Console.ReadKey();
        }

        static void TentangSaya(){
            Console.WriteLine("=== Tentang Saya ===");
            Console.WriteLine("Nama saya adalah Ricky Adiputra");
            Console.WriteLine("Pengalaman belajar saya selama sesi 1 sampai 5 sejauh ini aman karena sudah pernah belajar c#");
            Console.WriteLine("Di saat sudah jenuh, saya biasanya bermain game untuk menghilangkan jenuh");
            Console.ReadKey();
        }

        static void Link(){
            Console.WriteLine("=== Link Github ===");
            Console.WriteLine("Link Github : https://github.com/rampartblade/Bootcamp/tree/main/sesi%205");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            do{
                Menu();
                Console.Write("Pilih : ");
                int choose = int.Parse(Console.ReadLine());
                Console.Clear();
                if(choose == 1){
                    Airplane();
                    Console.Clear();
                }
                
                else if(choose == 2){
                    Overloading();
                    Console.Clear();
                }

                else if(choose == 3){
                    Bilangan();
                    Console.Clear();
                }

                else if(choose == 4){
                    TentangSaya();
                    Console.Clear();
                }
                
                else if(choose == 5){
                    Link();
                    Console.Clear();
                }

                else if(choose == 6){
                    break;
                }
            }while(true);
        }
    }
}
