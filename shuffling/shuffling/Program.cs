using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<string > list = new List<string>() { "bomba", "zold", "ujrakever", "nope"};

            void shuffle()
            {
                int utolsoI = list.Count() - 1;
                while (utolsoI > 0)
                {
                    string temp = list[utolsoI];
                    int randomI = r.Next(0, utolsoI);
                    list[utolsoI] = list[randomI];
                    list[randomI] = temp;
                    utolsoI--;
                }
            }
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            shuffle();

            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
