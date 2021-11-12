using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ссума чисел через пробел
            Console.WriteLine("Введите целые числа через пробел и нажмите: ввод");
            int Add(params int[] array)
            {
                return array.Sum();
            }
            var x = Console.ReadLine();
            var y = x.Split().Select(int.Parse).ToArray();
            Console.WriteLine(Add(y));
            Console.WriteLine("\t\t***\n");

            (string firstName, string lastName, string patronymic)[] users = GetFullNames();
            PrintUsers(users);

            Console.WriteLine("Введите номер месяца");
            int munth = Convert.ToInt32(Console.ReadLine());
        }
        static Seasons GetSeasons(ref int munth)
        {
            Seasons result;
            if (munth >= 3 && munth <= 5)
            {
                result = Seasons.Spring;
            }
            else
            {
                if (munth >= 6 && munth <= 8)
                {
                    result = Seasons.Summer;
                }
                else
                {
                    if (munth >= 9 && munth <= 11)
                    {
                        result = Seasons.Autumn;
                    }
                    else
                    {
                        result = Seasons.Winter;
                    }
                }
            }
            return result;
        }
        

           
        
        [Flags]
        enum Seasons
        {
            nul = 0b00000000,
            Winter = 0b00000001,
            Spring = 0b00000010,
            Summer = 0b00000100,
            Autumn = 0b00001000,
        }

        static (string firstName, string lastName, string patronymic) GetFullName()
        {
            Console.WriteLine("Привет! Как тебя зовут?");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Привет! " + firstName + " Какая у  тебя фамилия?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Привет! " + firstName + " Какое у  тебя отчество?");
            string patronymic = Console.ReadLine();
            return (firstName, lastName, patronymic);
        }

        static (string firstName, string lastName, string patronymic)[] GetFullNames()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = Convert.ToInt32(Console.ReadLine());
            (string firstName, string lastName, string patronymic)[] users =
                new (string firstName, string lastName, string patronymic)[count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = GetFullName();
                Console.WriteLine($"Пользователь {FormatUserData(users[i])} сохранен");
            }
            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            return users;
        }
        static void PrintUser((string firstName, string lastName, string patronymic) user)
        {
            Console.WriteLine(FormatUserData(user));
        }

        static string FormatUserData((string firstName, string lastName, string patronymic) user)
        {
            return $"{user.firstName} {user.lastName} {user.patronymic}";
        }
        static void PrintUsers((string firstName, string lastName, string patronymic)[] users)
        {
            Console.WriteLine("Вывод всех пользователей:");
            for (int i = 0; i < users.Length; i++)
            {
                PrintUser(users[i]);
            }
        }




    }
}
 
