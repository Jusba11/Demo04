using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApp
{
    class Hissi
    {
        private readonly int maxKerros = 5;
        private readonly int minKerros = 1;

        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value <= maxKerros && value >= minKerros) // jos kerros on välillä 1-5
                {
                    kerros = value;
                }
                else
                {
                    Console.WriteLine("Hissi ei kulje tuohon kerrokseen. Valitse kerros 1-5.");
                }
            }
        }


    }
}
