using System;

public class RickyAdiputra_023_Assignment1
{
    static void Menu(){
        Console.WriteLine("=== Welcome To Assignment 1 ");
        Console.WriteLine("Nama          \t: Ricky Adiputra");
        Console.WriteLine("Nomor Peserta \t: 023");
        Console.WriteLine("Domisili      \t: Jakarta");
        Console.WriteLine("1. Soal 1 (Segitiga Alfabet)");
        Console.WriteLine("2. Soal 2 (Segitiga Angka)");
        Console.WriteLine("3. Soal 3 (Faktorial)");
        Console.WriteLine("4. Soal 4 (Reverse Number)");
        Console.WriteLine("5. Soal 5 (Convert Angka)");
        Console.WriteLine("6. Soal 6 (Palindrome)");
        Console.WriteLine("7. Exit");
    }
    static void Main(string[] args){
        do{
            Menu();
            Console.Write("Choose = ");
            int choose = int.Parse(Console.ReadLine());
            Console.Clear();
            if(choose == 1){
                string [] abjad = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
                int count = 0;
                int counter = 0;
                Console.WriteLine("=== Segitiga Alfabet ===");
                Console.WriteLine("");
                Console.Write("Berapa range abjad yang diinginkan(Gunakan huruf sebagai acuan banyak baris)? ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();
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
                Console.WriteLine();
                Console.WriteLine("Press Any Key");
                Console.ReadKey();
                Console.Clear();
            }
            if(choose == 2){
                Console.WriteLine("=== Segitiga Angka ===");
                Console.WriteLine("");
                Console.Write("Enter the triangle range = ");
                int input = int.Parse(Console.ReadLine());
                int count = 1;
                int counter = 0;
                Console.WriteLine();
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
                Console.WriteLine();
                Console.WriteLine("Press Any Key");
                Console.ReadKey();
                Console.Clear();
            }

            if(choose == 3){
                Console.WriteLine("=== Factorial ===");
                Console.WriteLine("");
                Console.Write("Enter Any Factorial Number : ");
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
                    if (n > 1){
                        Console.Write($"{n} x ");
                    }
                    else if(n == 1){
                        Console.Write("1");
                    }
                    n--;
                }
                Console.WriteLine();
                Console.Write($"factorial {i} is {hasil}");  
                Console.WriteLine("\n");
                Console.WriteLine("Press Any Key");
                Console.ReadKey();  
                Console.Clear();
            }

            if(choose == 4){
                Console.WriteLine("=== Reverse Number ===");
                Console.WriteLine("");
                Console.Write("Enter a number : ");
                string angka = Console.ReadLine();
                int count = angka.Length - 1;
                Console.Write("Reversed number : ");
                while (count >= 0)
                {
                    Console.Write(angka[count]);
                    count--;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Press Any Key");
                Console.ReadKey(); 
                Console.Clear();
            }

            if(choose == 5){
                Console.WriteLine("=== Convert Angka ===");
                Console.WriteLine("");
                Console.Write("Enter a number \t: ");
                string number = Console.ReadLine();
                int temp = number.Length;
                string[] words =
                {
                    "one","two","three","four","five","six","seven","eight","nine"
                };
                Console.Write("The result is \t: ");
                for(int i = 0; i < temp; i++)
                {
                    if(number[i] == '1')
                    {
                        Console.Write($"{words[0]} ");
                    }
                    else if(number[i] == '2')
                    {
                        Console.Write($"{words[1]} ");
                    }
                    else if(number[i] == '3')
                    {
                        Console.Write($"{words[2]} ");
                    }
                    else if(number[i] == '4')
                    {
                        Console.Write($"{words[3]} ");
                    }
                    else if(number[i] == '5')
                    {
                        Console.Write($"{words[4]} ");
                    }
                    else if(number[i] == '6')
                    {
                        Console.Write($"{words[5]} ");
                    }
                    else if(number[i] == '7')
                    {
                        Console.Write($"{words[6]} ");
                    }
                    else if(number[i] == '8')
                    {
                        Console.Write($"{words[7]} ");
                    }
                    else if(number[i] == '9')
                    {
                        Console.Write($"{words[8]} ");
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("Press Any Key");
                Console.ReadKey();
                Console.Clear();                
            }

            if(choose == 6){
                Console.WriteLine("=== Palindrome Check ===");
                Console.WriteLine("");
                Console.Write("Enter Word : ");
                int temp = 0;
                string kata = Console.ReadLine();
                char [] word = new char[kata.Length];
                bool check = true;
                int count = kata.Length - 1;
                while (count >= 0 && check)
                {
                    word[temp] = kata[count];
                    if(word[temp] == kata[temp])
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                    count--;
                    temp++;
                }
                if(check)
                {
                    Console.WriteLine("word is a palindrome");
                }
                else
                {
                    Console.WriteLine("word is not a palindrome");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Press Any Key");
                Console.ReadKey();
                Console.Clear();                
            }

            if(choose == 7){
                break;
            }

        }while(true);
    }
}