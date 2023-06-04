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
        }
    }
}