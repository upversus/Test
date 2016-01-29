using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            myStructure structure1 = new myStructure();
            myStructure structure2 = new myStructure();

            structure1.a = 10;
            structure2.a = 20;

            Console.WriteLine("S1.a={0}, S2.a={1}", structure1.a, structure2.a);

            structure1.a = structure2.a;

            Console.WriteLine("S1.a={0}, S2.a={1}", structure1.a, structure2.a);

            structure2.a = 5;

            Console.WriteLine("S1.a={0}, S2.a={1}", structure1.a, structure2.a);

            structure1 = structure2;

            Console.WriteLine("S1.a={0}, S2.a={1}", structure1.a, structure2.a);

            structure1.a = 23;

            Console.WriteLine("S1.a={0}, S2.a={1}", structure1.a, structure2.a);

            structure1 = structure2;

            Console.WriteLine("S1.a={0}, S2.a={1}", structure1.a, structure2.a);

            structure2.a = 100;

            Console.WriteLine("S1.a={0}, S2.a={1}", structure1.a, structure2.a);

            Console.ReadKey();
        }


        struct myStructure
        {
            public int a;
            public int b;
        }
    }
}
