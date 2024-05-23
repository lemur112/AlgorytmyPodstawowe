using System;

namespace Algorytmy
{
    class Program
    {
        Sort sort = new Sort();

        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Sort.SortowanieMalejaco(array);
            Sort.WyswietlaniePosortowanejTablicy(array);
            

            Console.ReadLine();
        }
    }
}

