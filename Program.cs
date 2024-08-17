using System;

namespace TaskJunior2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageFromTheUser;
            int numberOfRepetitions;

            Console.WriteLine("Добро пожаловать в 'МИР ПОВТОРЯЮЩИХСЯ СООБЩЕНИЙ'.\n");
            Console.Write("Введите сообщение : ");
            messageFromTheUser = Console.ReadLine();
            Console.Write("Введите кол-во повторений : ");
            numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Console.WriteLine(messageFromTheUser);
            }
        }
    }
}
