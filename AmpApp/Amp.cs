using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApp
{
    class Amp
    {
        private readonly int maxVol = 100;
        private readonly int minVol = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVol && value >= minVol) // varmistetaan että vol on turvallinen.
                {
                    volume = value;
                }
                else
                {
                    if (value > 1) // jos luku on liian suuri..
                    {
                        Console.WriteLine("Liian kova volume! laitetaan maksimiin.");
                        volume = maxVol;
                    }
                    else if (value < 0)
                    {

                        Console.WriteLine("Liian pieni volume! laitetaan minimiin.");
                        volume = minVol;
                    }
                }
            }
        }
    }
}
