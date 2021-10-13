using System;

public class pesawat{
    public string nama;
    public string ketinggian;
    public string penumpang;
    public int roda;
    public void terbang(){
        Console.WriteLine($"Pesawat tempur dengan nama {this.nama}, yang mempunyai jumlah roda {this.roda}, sedang berada di ketinggian {this.ketinggian} dengan membawa penumpang sebanyak {this.penumpang}");
    }
}

public class pesawat_tempur:pesawat{
    public void terbangtinggi(){
        Console.WriteLine($"Pesawat tempur dengan nama {this.nama}, yang mempunyai jumlah roda {this.roda}, sedang berada di ketinggian {this.ketinggian} dengan membawa penumpang sebanyak {this.penumpang}");
    }
}