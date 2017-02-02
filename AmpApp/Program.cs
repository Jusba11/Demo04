using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();
            
            do
            {
                Console.Write("Anna volume väliltä 0-100 >");
                string syote = Console.ReadLine();
                amp.Volume = int.Parse(syote);

                Console.WriteLine("volume: " + amp.Volume);

            } while (1 == 1);
        }
    }
}
