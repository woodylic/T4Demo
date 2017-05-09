using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using T4Ddemo.Entity;

namespace T4Demo
{
    class Program
    {
        public static void Main(String[] args)
        {
            var dict = Greeting.GetGlobalGreetings();
            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + ", " + item.Value);                
            }

            Console.ReadKey();
        }
    }
}
