using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Class1 //сузоны
    {
        static void Main()
        {
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


            if (munth >= 6 && munth <= 8)
            {
                result = Seasons.Summer;
            }


            if (munth >= 9 && munth <= 11)
            {
                result = Seasons.Autumn;
            }

            {
                result = Seasons.Winter;
            }
                return result;
        }
        //[Flags]
        enum Seasons
        {
            nul = 0b00000000,
            Winter = 0b00000001,
            Spring = 0b00000010,
            Summer = 0b00000100,
            Autumn = 0b00001000,
        }
    }
}
