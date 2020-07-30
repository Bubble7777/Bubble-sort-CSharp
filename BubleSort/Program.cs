using System;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    class Program
    {
        /* static void Swap(int[] items, int left, int right)
         {
             if (left != right)
             {
                 int temp = items[left];
                 items[left] = items[right];
                 items[right] = temp;
             }
         }

         public static void BubbleSort(ref int[] items)
         {
             bool swapped;
             do
             {
                 swapped = false;

                 for (int i = 1; i < items.Length; i++)
                 {
                     if (items[i - 1].CompareTo(items[i]) > 0)
                     {
                         Swap(items, i - 1, i);
                         swapped = true;
                     }
                 }
             } while (swapped != false);
         }*/

        /*static int[] BubbleSort(int[] arrays)
         {
             int temp; // buffer variable
             for (int i = 0; i < arrays.Length; i++) // left element
             {
                 for (int j = i + 1; j < arrays.Length; j++) // rigth element 
                 {
                     if (mas[i] > mas[j])
                     {
                         temp = mas[i];
                         arrays[i] = arrays[j];
                         arrays[j] = temp;
                     }
                 }
             }
             return mas;
         }*/
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 7, 1, 5, 45, 15,-1,2,9 };

            Console.WriteLine("Массив до сортировки");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            BubbleSort(array);

            Console.WriteLine(" \nОтсортированый Массив");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadKey();
        }
    }
}
