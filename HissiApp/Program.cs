using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            do
            {
                hissi.Kerros = 1;
                Console.Write("Anna kerros jonne haluat mennä. Valitse 1-5 >");
                string syote = Console.ReadLine();
                hissi.Kerros = int.Parse(syote);

                Console.WriteLine("Hissi kerroksessa: " + hissi.Kerros);

            } while (1 == 1);
            
        }
    }
}
