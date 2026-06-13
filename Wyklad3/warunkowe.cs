class Warunkowe
    {
    public static void mojif()
        {
            int liczba = 1;
            if (liczba > 5)
            {
                Console.WriteLine("Liczba jest większa niż 5");
            }
            else if (liczba == 5)
            {
                Console.WriteLine("Liczba jest równa 5");
            }
            else
            {
                Console.WriteLine("Liczba jest mniejsza niż 5");
            }
        }    
public static void mojswitch()
        {   
            int liczba = 2;
            switch (liczba)
            {
                case 1:
                    Console.WriteLine("Liczba jest równa 1");
                    break;
                case 2:
                    Console.WriteLine("Liczba jest równa 2");
                    break;
                case 3:
                    Console.WriteLine("Liczba jest równa 3");
                    break;
                default:
                    Console.WriteLine("Liczba jest inna niż 1, 2 lub 3");
                    break;
            }
            

        }

    }

