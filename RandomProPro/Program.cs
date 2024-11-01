using System;

namespace RandomProPro
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 10000;
            int random_num = new Random().Next(100);
            do
            {
                Console.WriteLine("Введи число или сдайся отправив -1: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == random_num) Console.WriteLine("Это оно!");
                
                if (input == -1)
                {
                    Console.WriteLine("Ответом было: " + random_num);
                    random_num = input;
                }
                if (input < random_num)
                {
                    Console.Clear();
                    Console.WriteLine("Число должно быть больше");
                }

                if (input > random_num)
                {
                    Console.Clear();
                    Console.WriteLine("Число должно быть меньше");
                }
            } 
            while (input != random_num);
        }
    }
    
}
