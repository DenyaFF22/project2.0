using System;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первоt число для сложения");
            string s = Console.ReadLine( );
            int a = Convert.ToInt32(s); 
            
            Console.WriteLine("Введите второе число сложения");
            string s2 = Console.ReadLine();
            int b = Convert.ToInt32(s2); 

            int c = a + b;
            Console.WriteLine("Сумма данных чисел:");
            Console.WriteLine(c);
            Console.ReadLine();
            
        
        }
    }
}