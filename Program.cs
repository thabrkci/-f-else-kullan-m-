using System.Net.Http.Headers;

namespace İf_else_kullanımı;

class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if(time>6 && time<12)//saat 6'dan sonra ise ve 12'den önce ise Günaydın Diyecektir.
        Console.WriteLine( "Günaydin!");
        else if(time<= 18)
        Console.WriteLine("İyi Günler!");
        else
        Console.WriteLine("İyi geceler!");

        string sonuc = time<=18 ? "İyi günler!" : "İyi geceler!";
        sonuc = time>=6 && time<12 ? "Günaydin" : time<=18 ? "İyi Günler!" :"İyi Geceler";
        Console.WriteLine(sonuc);

    


        
    }
}
