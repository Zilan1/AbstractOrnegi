public abstract class Kisi
{
    public string AdSoyad;

    public abstract string Meslek
    {
        get;
    }
    public virtual void Yaz()
    {
        Console.WriteLine("Ad Soyad: " + AdSoyad);
        Console.WriteLine("Meslek: " + Meslek);
    }
}
public class Ogrenci:Kisi
{
    public int Sinif;
    public override string Meslek
    {
        get
        {
            return "Öğrenci";
        }
    }
    public override void Yaz()
    {
        Console.WriteLine("Ad Soyad: " + AdSoyad);
        Console.WriteLine("Sinif: " + Sinif);
        Console.WriteLine("Meslek: " + Meslek);

    }
}
public class Ogretmen:Kisi
{
    public string Brans;
    public override string Meslek
    {
        get
        {
            return "Öğretmen";
        }
    }
    public override void Yaz()
    {
        Console.WriteLine("Ad Soyad: " + AdSoyad);
        Console.WriteLine("Meslek: " + Meslek);
        Console.WriteLine("Brans: " + Brans);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.AdSoyad = "Zilan Ozguc";
        ogrenci1.Sinif = 2;
        ogrenci1.Yaz();

        Ogretmen ogretmen1=new Ogretmen();
        ogretmen1.AdSoyad = "Gulsum Kamer";
        ogretmen1.Brans = "Bilişim Teknolojileri";
        ogretmen1.Yaz();

        Console.ReadLine();
    }
}
