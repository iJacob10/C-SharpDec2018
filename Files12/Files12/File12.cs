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
            f1.printFun2();

            File2 f2 = new File2();
            f2.printfun();

            File3 f3 = new File3();
            f3.printfun();

            File4 f4 = new File4();
            f4.printfun();
            //New comment - 2 from VS
            File5 f5 = new File5();
            f5.printfun();

            File6 f6 = new File6();
            f6.printfun();

            Console.WriteLine("Sample Code")

            Console.ReadKey();
        }
        public void printfun()
        {
            int i = 1;
            Console.WriteLine("Hello for file " + i);
        }
        public void printFun2()
        {
            int i = 22;
            Console.WriteLine("Error" + i);
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

