using System;

namespace laba_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа 2. Массивы 2:Вывести количество положительных элементов.");
            int v = 32;
            Console.WriteLine("                                " + ((v % 15) + 1) + " Вариант");
            Console.Write("Введите количество элементов:");
            var len = int.Parse(0 + Console.ReadLine());


            int count = 0;
            var array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + 1 + " Элемент = ");
                array[i] = int.Parse(Console.ReadLine());


            }
            Console.Write("Количество положительных элементов в массиве: ");

            for (int i = 0; i < array.Length; i++)


                if (array[i] > 0)



                    count ++;




            Console.Write(count);



            Console.ReadKey();
        }
    }
}
