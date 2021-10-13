using System;

public class overloading{
    public string nama;
    public double nomor;
    public void print(string nama){
        this.nama = nama;
        Console.WriteLine("Namanya adalah : {0}", this.nama);
    }

    public void print(double nomor){
        this.nomor = nomor;
        Console.WriteLine("Nomor HP : {0}", this.nomor);
    }
}