using System;

namespace RandomProPro
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++) Console.Write("#");
            Console.WriteLine("\nВведи ка число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            // реализация bad алгоритма представлена на 15 строке
            
            int rand_num = (num + 7932) * 5 % 123;
            
            Console.WriteLine("Рандомно преисполненное: " + rand_num);
        }
    }
    
}
