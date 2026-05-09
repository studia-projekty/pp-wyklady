using System.Text;
namespace Const
internal class Program
{
    private static void Main(string[] args)
    {
        operatory();
    }


private static void Zmienne()
    {
        bool czyPada=false;
        Console.WriteLine($"Czy pada? (true/false){czyPada}");
        
        byte wiek = 25;
        Console.WriteLine($"Wiek: {wiek}");
        sbyte temperatura = -5;
        Console.WriteLine($"Temperatura: {temperatura}");
        int liczba = 1000;
        Console.WriteLine($"Liczba: {liczba}");
        ushort krotkaLiczba = 100;
        Console.WriteLine($"krotkaLiczba: {krotkaLiczba}");
        short malaLiczba = -100;
        Console.WriteLine($"malaLiczba: {malaLiczba}");
        long duzaLiczba = 10000000000000;
        Console.WriteLine($"Duża liczba: {duzaLiczba}");
        ulong bardzoDuzaLiczba = 12321354654315135131;
        Console.WriteLine($"Bardzo Duża liczba: {bardzoDuzaLiczba}");
        var liczba2 = 450000L;
        Console.WriteLine($"Zmienna var: {liczba2}");
        decimal cena = 19.99M;
        Console.WriteLine($"Cena: {cena}");
        double pi = 3.14159;
        Console.WriteLine($"Pi: {pi}");
        float e = 2.171828f;
        char znak = 'A';
        Console.WriteLine($"Znak: {znak}");

    }

    static void Typy_lancuchowe()
    {

        string imie = "JAn";
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");
        string lokalizacja = @"c:\Programy\abc";     // escapowanie znakow specjalnych za pomoca @ bo np. \a to jest znak specjalny
        Console.WriteLine(sb.ToString());
        Console.WriteLine($"Lokalizacja: {lokalizacja}");

    }

    static void Typy_referencyjne()
    {
        string imie = "Ala ma kota";
        string b = imie;
       

        imie = "Ala ma psa";
        Console.WriteLine(imie);
        Console.WriteLine(b);


    }

    static void ZmiennaDynamiczna()
    {
    dynamic zmienna = 5;
    Console.WriteLine(zmienna);
    zmienna = "tekst";
    Console.WriteLine(zmienna);
    }

    static void TypyWskaznikowe()
    {

        int* a = 5;
        int* b = &a;  ///&a  oznacza costam w pamieci

        Console.WriteLine("*b");

    }

    static void konwersja()
    {
        
        int wartosc1 = 5;
        byte wartosc2 = 10;

        wartosc1 = wartosc2;
        
        Console.WriteLine("wartosc 1: " + wartosc1 );

        double wartosc3 = 3.1459;
        int i;
        i = (int)wartosc3;
        Console.WriteLine("Wartosc 3: " + wartosc3 );
        Console.WriteLine("wartosc i: " + i );

        var zmienna = Convert.ToSingle(wartosc1);
        var wynik = "Wynik moich obliczen to " + wartosc3.ToString();
        Console.WriteLine(wynik);
        Console.WriteLine(wartosc1);

        // literały i zapis zmiennych
        // 212
        // 212u   "ulong"
        // 0xBeef   -   
        //
    }

    static void namespaceConst ()
    {
        
        const double Pi = 3.14;
        Console.WriteLine("Wartość Pi: " + Pi);
        Pi *=2;  // const sie nie zmienia nigdy, więc nie można pomnożyć *2.

    }

    static void operatory()
    {
        var a = 2+3;
        Console.WriteLine("Wynik: " + a);
        var b = 2-3;
        Console.WriteLine("Wynik: " + b);
        var c = 2*3;
        Console.WriteLine("Wynik: " + c);       

        //operatory arytmetyczne 
        var f = 10;
        f++;
        Console.WriteLine("Wynik: " + f); 
        f--;
        Console.WriteLine("Wynik: " + f);
        f*=;
        Console.WriteLine("Wynik: " + f);   
        f/=;
        Console.WriteLine("Wynik: " + f);    

        //operatory relacyjne 
        int g = 5;
        int h = 10;
        Console.WriteLine(a > b);   
        Console.WriteLine(a < b); 
         Console.WriteLine(a == b);
        Console.WriteLine(a != b);  
        Console.WriteLine(a >= b);  
        Console.WriteLine(a <= b); 

        //operatory logiczne
        bool x = true;
        bool y = false;
        Console.WriteLine(x && y);
        Console.WriteLine(x || y);
        Console.WriteLine(!x);
        Console.WriteLine(!y);

        
        // do potegowania i pierwiastkow uzywamy metod: 
        var d = Math.Pow(2, 3);
        Console.WriteLine("Wynik: " + d);
        var e = Math.Sqrt(9);
        Console.WriteLine("Wynik: " + e);     

    }

}