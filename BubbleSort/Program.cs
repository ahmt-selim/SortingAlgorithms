using System;

namespace BubbleSort
{
    class Program
    {
        //Sıralama Algoritmaları - Buble Sort(Baloncuk Sıralama)
        //En büyüğü en sona taşıma şeklinde ilerler
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Ali", "Veli", "Ayşe", "Fatma" };
            int[] numbers = { 5, 2, 7, 9, 1, 0, 6, 3, 4, 10, 8 };

            void BubleSort<T>(T[] array) where T : IComparable
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length-1-i; j++)
                    {
                        if (array[j].CompareTo(array[j+1]) > 0)
                        {
                            var key = array[j];
                            array[j] = array[j+1];
                            array[j + 1] = key;
                        }
                    }
                }
            }
            BubleSort(numbers);
            BubleSort(names);
            Console.WriteLine(string.Join(',', numbers));
            Console.WriteLine(string.Join(',', names));
            Console.ReadLine();
        }
    }
}
