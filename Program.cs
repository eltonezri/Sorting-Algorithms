using System;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomstr = "";
        choices:
            Console.WriteLine("Press [1] to populate the arraylist with random numbers!\nPress [2] to print the values of the arraylist~\nPress [3] to use the insertion sort algorthm to sort the numbers~\nPress [4] to use the selection sort algorithm to sort the numbers~\nPress [5] to use bubble sort algorithm to sort the numbers~\npress [6] to exit~");
            int choices = int.Parse(Console.ReadLine());

            switch (choices)
            {
                case 1:
                    randomstr = RandomNumbers();
                    goto choices;
                case 2:
                    Console.WriteLine(randomstr);
                    goto choices;
                case 3:
                    Console.WriteLine(randomstr);
                    Insertion_Sort_Algorithm(randomstr);
                    goto choices;
                case 4:
                    Console.WriteLine(randomstr);
                    Selection_sort_Algorithm(randomstr);
                    goto choices;
                case 5:
                    Console.WriteLine(randomstr);
                    Bubble_Sort_Algorithm(randomstr);
                    goto choices;
                case 6:
                    
                    break;
            }
        }
        static string RandomNumbers()
        {

            Random r = new Random();
            int[] array = new int[10];
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = r.Next(10, 100);
            }
            string a = string.Join(" ", array);
            return a;
        }
        static void Insertion_Sort_Algorithm(string a)
        {
            String[] strlist = a.Split(" ");
            int[] array_a = new int[10];
            for (int i = 0; i < strlist.Length; i++)
            {
                array_a[i] = int.Parse(strlist[i]);
            }
            for (int i = 0; i < array_a.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array_a[j - 1] > array_a[j])
                    {
                        int temp = array_a[j - 1];
                        array_a[j - 1] = array_a[j];
                        array_a[j] = temp;
                    }
                }
                string BSA = string.Join(" ", array_a);
                Console.WriteLine();
                Console.WriteLine(BSA);
            }
        }
        static void Selection_sort_Algorithm(string a)
        {
            String[] strlist = a.Split(" ");
            int[] array_a = new int[10];
            for (int i = 0; i < strlist.Length; i++)
            {
                array_a[i] = int.Parse(strlist[i]);
            }
            int temp, smallest;
            for (int i = 0; i < array_a.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < array_a.Length; j++)
                {
                    if (array_a[j] < array_a[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array_a[smallest];
                array_a[smallest] = array_a[i];
                array_a[i] = temp;
                string BSA = string.Join(" ", array_a);
                Console.WriteLine();
                Console.WriteLine(BSA);
            }
        }
        static void Bubble_Sort_Algorithm(string a)
        {
            String[] strlist = a.Split(" ");
            int[] array_a = new int[10];
            for (int i = 0; i < strlist.Length; i++)
            {
                array_a[i] = int.Parse(strlist[i]);
            }
            for (int outer = 0; outer < array_a.Length; outer++)
            {
                int temp = 0;
                for (int x = 0; x < array_a.Length - 1; x++)
                {
                    if (array_a[x] > array_a[x + 1])
                    {
                        temp = array_a[x];
                        array_a[x] = array_a[x + 1];
                        array_a[x + 1] = temp;
                    }
                }
                string BSA = string.Join(" ", array_a);
                Console.WriteLine();
                Console.WriteLine(BSA);
            }

        }
    }
}
