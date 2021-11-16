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

            // список ФИО
            (string firstName, string lastName, string patronymic)[] users = GetFullNames();
            PrintUsers(users);
            Console.Clear();
            Console.WriteLine("\t\t***\n");
            
            //месяцы
            Console.WriteLine("Введите номер месяца и нажмите: ввод");
            var input = Console.ReadLine();
            var inputAsNumber = Convert.ToInt32(input);
            var season = GetSeason(inputAsNumber);
            var seasonName = GetSeasonName(season);
            Console.WriteLine(seasonName);
            Console.Clear();
            Console.WriteLine("\t\t***\n");
            

            Seasons GetSeason(int month)
            {
                if (month == 12 || month < 3)
                {
                    return Seasons.Winter;
                }
                if (month < 6)
                {
                    return Seasons.Spring;
                }
                if (month < 9)
                {
                    return Seasons.Summer;
                }
                if (month < 12)
                {
                    return Seasons.Autumn;
                }
                return Seasons.Summer;
            }

            string GetSeasonName(Seasons season)
            {
                switch (season)
                {
                    case Seasons.Winter:
                        return "Зима";
                    case Seasons.Spring:
                        return "Весна";
                    case Seasons.Summer:
                        return "Лето";
                    case Seasons.Autumn:
                        return "Осень";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(season), season, null);
                }
            }
        }

        enum Seasons
        {
            //null = 0b00000000,
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
            Console.WriteLine("Введите количество пользователей и нажмите: ввод");
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
