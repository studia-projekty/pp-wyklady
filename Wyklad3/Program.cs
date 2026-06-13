internal class Program
{
    private static void Main(string[] args)
    {
       // Warunkowe.mojif();
       // Warunkowe.mojswitch();
        //Petla.PetlaFor();
        // Petla.PetlaWhile();
        // Petla.PetlaDoWhile();

        //Console.WriteLine("Podaj dwie liczby:");
       // int a = int.Parse(Console.ReadLine());
       // int b = int.Parse(Console.ReadLine());
       // int c = Funkcje.MojaFunkcja(a, b);
        //Console.WriteLine($"Wynik: {c}");


Console.WriteLine("Podaj liczbę:");
int n = int.Parse(Console.ReadLine());
int wynik = Funkcje.Silnia(n);
Console.WriteLine($"Silnia z {n} to: {wynik}");
    }




}

