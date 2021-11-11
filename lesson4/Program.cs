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
            int Add(params int[] array)
            {
                return array.Sum();
            }

            var y = Add(1, 2, 3, 6, 5, 4);
            //var x = Add(y);
            Console.WriteLine(y);
        }  
    }
}
