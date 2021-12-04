using System;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите первое число");
            var s = Console.ReadLine();
            int a = Convert.ToInt32(s); 
            
            Console.WriteLine("Введите второе число");
            var e  = Console.ReadLine();
            int b = Convert.ToInt32(e); 
            
              
            Console.WriteLine("Какая арефметическая операция будет выполнена");
        
            Console.ReadLine();

            string name = "+" ;

            switch (name)
            {
               case "+":
                Console.WriteLine("+");
                break;
               case "-":
                Console.WriteLine("-");
                break;
                case "*":
                Console.WriteLine("*");
                break;
                case "/":
                Console.WriteLine("/");
                break;


            }
                int c = a + b;
                Console.WriteLine("Ответ");
                Console.WriteLine(c);
                Console.ReadLine();

                string namet = "-" ;

            switch (namet)
            {
               case "+":
                Console.WriteLine("+");
                break;
               case "-":
                Console.WriteLine("-");
                break;
                case "*":
                Console.WriteLine("*");
                break;
                case "/":
                Console.WriteLine("/");
                break;


            }
                int m1 = a - b;
                Console.WriteLine("ответ");
                Console.WriteLine(m1);
                Console.ReadLine();  
            string names = "*" ;

            switch (names)
            {
               case "+":
                Console.WriteLine("+");
                break;
               case "-":
                Console.WriteLine("-");
                break;
                case "*":
                Console.WriteLine("*");
                break;
                case "/":
                Console.WriteLine("/");
                break;


            }
                int u1 = a * b;
                Console.WriteLine("Ответ:");
                Console.WriteLine(u1);
                Console.ReadLine();

            var f = Console.ReadLine();
            int m = Convert.ToInt32("-");
            var k = Console.ReadLine();
            int p = Convert.ToInt32("+");
            var g = Console.ReadLine();
            int u = Convert.ToInt32("*");
            var h = Console.ReadLine();
            int d = Convert.ToInt32("/");

            
            
            
           string namer = "/" ;

            switch (namer)
            {
               case "+":
                Console.WriteLine("+");
                break;
               case "-":
                Console.WriteLine("-");
                break;
                case "*":
                Console.WriteLine("*");
                break;
                case "/":
                Console.WriteLine("/");
                break;

            }
                int d1 = a / b;
                Console.WriteLine("Ответ:");
                Console.WriteLine(d1);
                Console.ReadLine();
        }
    }
}