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
            var x = Console.ReadLine();
            var y = x.Split().Select(int.Parse).ToArray();
            Console.WriteLine(Add(y));
        }  
    }
} 
