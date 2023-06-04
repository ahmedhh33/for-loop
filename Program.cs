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

            int f = 1;
            Console.WriteLine();
            f += 3;
            Console.WriteLine(a+=3);
            Console.WriteLine(++f);


            Console.WriteLine("printing odd numders between two numbers");
            Console.WriteLine("Enter the vale of starting number = ");
            int st = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the vale of ending number = ");
            int en = int.Parse(Console.ReadLine());
            Console.WriteLine("******************");
            for(int i = st ;i<=en ;i++)
            {
                //Console.WriteLine((2*i)+1);
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }

            }
            int fact = 1;
            Console.WriteLine("/n");
            Console.WriteLine("Calculate Factor of : ");
            int num = int.Parse(Console.ReadLine());
            for ( int i = 1 ;i<=num ;i++)
            {
                fact = fact * i;
            }
            Console.Write("factoraial of " + num + " is " + fact);
        }
    }
}