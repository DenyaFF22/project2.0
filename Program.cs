using System;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'д';
            while(again== 'д')
{
            double a;
            double b;
            double total;
            char oper;

            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            
              
            Console.WriteLine("Какая арефметическая операция будет выполнена");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            if (oper =='+')
                           {
                               total = a + b;
                               Console.WriteLine("Сумма " + total +"" );
                            }
                            
                                else if (oper == '-')
                                {
                                    total = a - b;
                                    Console.WriteLine("Разность " + total +"");
                                     }
                                     else if (oper == '*')
                                     {
                                         total = a * b;
                                         Console.WriteLine("Умножение " + total +"");
                                     }
                               else if (oper =='/')
                               {
                                   total = a / b;
                                   Console.WriteLine("Деление " + total +"");
                               }
                               else 
                               {
                                   Console.WriteLine("Неизвестный оператор");
                               }
                               Console.WriteLine("Хотите продолжить работу? д/н");
                               again = Convert.ToChar(Console.ReadLine());
                               
                               
                                    
           }                    
        }
    }
}