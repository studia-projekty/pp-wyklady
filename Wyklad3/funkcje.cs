public class Funkcje
{
    public static int MojaFunkcja(int a, int b)
    {
        return a + b;
    }

    public static int Silnia(int n)
    {
        if (n == 1)
            return 1;
        else
             return n * Silnia(n - 1);
    }
}