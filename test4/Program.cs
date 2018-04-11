using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("Favorel", "Jacques", 1280);
            Console.WriteLine(c1.Decrire());
            

        }
    }
}
