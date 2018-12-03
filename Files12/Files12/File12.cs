using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1234
{
    class File12
    {
        static void Main(string[] args)
        {
            File12 f1 = new File12();
            f1.printfun();

            File2 f2 = new File2();
            f2.printfun();

            File3 f3 = new File3();
            f3.printfun();

            File4 f4 = new File4();
            f4.printfun();
            Console.ReadKey();
        }
        public void printfun()
        {
            int i = 1;
            Console.WriteLine("Hello for file " + i);
        }

    }
    class File2
    {
        public void printfun()
        {
            int i = 2;
            Console.WriteLine("Hello for file " + i);
        }
    }
}

