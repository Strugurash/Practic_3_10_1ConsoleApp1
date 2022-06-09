using System;

namespace Practic_3_10_1ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo btn; // тип переменной для хранения кнопки закрытия консоли.
            do
            {

                Console.WriteLine(" Введите число :");

                int a;

                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)


                {
                    Console.WriteLine(" Число чётное");
                    Console.WriteLine(" Для продолжения нажмите enter , для завершения нажмите escape");
                    
                }
                else
                {
                    Console.WriteLine(" Число нечётное");
                    Console.WriteLine(" Для продолжения нажмите enter , для завершения нажмите escape");
                    
                }
                

                btn = Console.ReadKey();
                Console.Clear();// очищает консоль.
            }
            while (btn.Key != ConsoleKey.Escape);


        }

    }
}
