using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            int[] tab = new int[100];
            int counter = 0;


            bool flaga = true;
            while (flaga)
            {

                input = Convert.ToInt32(Console.ReadLine());
                tab[counter] = input;
                if (input != 42)
                {
                    flaga = true;
                }
                else
                {
                    input = Convert.ToInt32(Console.ReadLine());
                  
                    flaga = false;
                }

                counter++;
              
            }

            counter--;


            Console.WriteLine("display :");

            for(int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{tab[i]}");
            }

            Console.ReadKey();
        }
    }
}
