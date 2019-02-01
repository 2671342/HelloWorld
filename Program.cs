using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Кому передаем привет?");
            string name = Convert.ToString(Console.ReadLine()); 
            Console.WriteLine("Привет " + name);
            Console.WriteLine("А вообще, иди ты " + name);

            Console.ReadKey();

        }
    }
}
