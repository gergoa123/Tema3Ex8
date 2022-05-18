using System;

namespace Tema3Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul: ");
            int numar = int.Parse(Console.ReadLine());
            int i = 1;

            for (i = 1; i <= numar; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    if (i % 3 != 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }


                }
                else
                {
                    Console.WriteLine(i);
                }

            }

                
        }

    }
}
