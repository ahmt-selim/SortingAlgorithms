using System;

namespace SelectionSort
{
    class Program
    {
        //Sıralama Algoritmaları - Selection Sort(Seçerek Sıralama)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Ali", "Veli", "Ayşe", "Fatma" };
            int[] numbers = { 5, 2, 7, 9, 1, 0, 6, 3, 4, 10, 8 };

            SelectionSort(numbers);
            SelectionSort(names);
            Console.WriteLine(string.Join(',', numbers));
            Console.WriteLine(string.Join(',', names));
            Console.ReadLine();
            void SelectionSort<T>(T[] array) where T : IComparable
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int minIndex = i;
                    for (int j = i+1; j < array.Length; j++)
                    {
                        if (array[j].CompareTo(array[minIndex]) > 0)
                        {
                            minIndex = j;
                        }
                    }
                    var temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
