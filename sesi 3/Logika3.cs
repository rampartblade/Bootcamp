using System;

public class Logika2
{
    static void Main(string[] args){
        Console.Write("Username \t: ");
        string username = Console.ReadLine();
        Console.Write("Password \t: ");
        string password = Console.ReadLine();
        if(username == "ocbc" && password == "bootcamp")
        {
            Console.WriteLine("Anda berhasil login");
        }
        else if(username == "" && password == "")
        {
            Console.WriteLine("username atau password tidak boleh kosong");
        }
        else
        {
            Console.WriteLine("username atau password salah");
        }
    }
}