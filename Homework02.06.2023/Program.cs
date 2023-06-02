using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02._06._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 5;
            string password = "123456";
            string userInput;

            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("Введите пароль:");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Секретики.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Введён неверный пароль!");
                    Console.WriteLine("У вас осталось " + (triesCount - (i + 1)) + " попыток!");
                }
            }
        }
    }
}
