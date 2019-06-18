using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{
    class Gasolina
    {
        string tanqueDeGasolina = "████";
        private int gasolinaInicial = 12;
        public int TanqueGasolina = 12;

        public void DesenhaGasolina()
        {
            if(TanqueGasolina > gasolinaInicial)
            {
                TanqueGasolina = gasolinaInicial;
            }
            for (int i = 0; i < TanqueGasolina; i++)
            {
                if(TanqueGasolina > gasolinaInicial /2 + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }else if(TanqueGasolina <= gasolinaInicial/2 && TanqueGasolina > 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if(TanqueGasolina <= gasolinaInicial/2-2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.SetCursorPosition(Program.Largura - 10, (Program.Altura - 4) - i);
                Console.Write(tanqueDeGasolina);
            }
        }
    }
}
