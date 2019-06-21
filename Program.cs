using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Importance value = Importance.Critical;

            if (value == Importance.Trivial)
            {
                Console.WriteLine("Not true");
            }

            Singleton mySingleton = Singleton.Instance;
            Singleton mySingleton2 = Singleton.Instance;
        }
    }
}
