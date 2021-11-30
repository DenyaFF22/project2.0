using System;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число для сложения");
            var s = Console.ReadLine();
            int.TryParse(s, out var a);

            Console.WriteLine("Введите второе число сложения");
            s = Console.ReadLine();
            int b = Convert.ToInt32(s);

            int c = a + b;
            Console.WriteLine("Сумма данных чисел:");
            Console.WriteLine(c);
            Console.ReadLine();



        }
    }
}