
    internal class Petla
    {
        public static void PetlaFor()
        {
            for(int i = 65; i < 73; i++)
            {
                for(int j = 1; j < 9; j++)
                {
                    Console.WriteLine($"Wartość i oraz j: {(char)i}, {j}");
                }
            }
        }
        public static void PetlaWhile()
        {
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("Wartość j: " + j);
                j++;
            }
        }

        public static void PetlaDoWhile()
        {
            int k = 0;
            do
            {
                Console.WriteLine("Wartość k: " + k);
                k++;
            } while (k < 5);
        }



    }
