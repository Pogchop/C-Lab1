using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class testA
    {
        public String name;
    }
    class Program
    {
            static void Main(string[] args)
            {
                int z = 1;
                Console.WriteLine("Test value tupe:");
                Console.WriteLine("The value of z before:" + z);
                
                Console.WriteLine("The value of z after:" + z);

                Console.WriteLine("Test reference type:");
                testA a = new testA();
                a.name = "not changed:";
                Console.WriteLine("The value of str before: " + a.name);
                changeValue2(a);
                Console.WriteLine("The value of str after:" + a.name);
                Console.ReadLine();
                Console.ReadKey();
            }
            public static void changValue(int k)
            {
                Console.WriteLine("[in chnageValue] original value: " + k);
                k = 100;
                Console.WriteLine("[in changeValue] new value " + k);
            }
            public static void changeValue2(testA v)
            {
                v.name = "changed it";
            }
    }
}
