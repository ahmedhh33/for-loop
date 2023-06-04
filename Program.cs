using System.Xml;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <5; i++)
            {

                Console.Write("*");
            }
            Console.WriteLine();
            for(int i = 0; i <3;i++)
            {
                Console.WriteLine("*   *");
            }
            for(int i = 0; i <5;i++)
            {
                Console.Write("*");
            }
            int a = 0;
            while (a<5)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine() ;
            int b = 2;
            do //start with the body
            { Console.WriteLine(b);
                b++;
            } 
            while (b<=5);
            int c = 1;
            Console.WriteLine();
            Console.WriteLine(c++);//post increment 1
            Console.WriteLine(++c);//preincrement  3
        }
    }
}