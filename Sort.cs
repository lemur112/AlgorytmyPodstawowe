using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorytmy
{
    class Sort
    {
        /************************************** 
         nazwa funkcji:        SortowanieMalejaco
        parametry wejściowe: array - tablica liczb całkowitych z zakresu int
         wartość zwracana:   zwraca posortowaną tablicę malejąco
        autor:               Bartosz Klimczak 3D
        *************************************/
        public static void SortowanieMalejaco(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }

        /************************************** 
         nazwa funkcji:        WyswietlaniePosortowanejTablicy
        parametry wejściowe: array - tablica liczb całkowitych z zakresu int
         wartość zwracana:   Wyświetla posortowaną tablicę
        autor:               Bartosz Klimczak 3D
        *************************************/
        public static void WyswietlaniePosortowanejTablicy(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
