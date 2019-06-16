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
        private int GasolinaInicial = 20;
        public int TanqueGasolina = 0;

        public void DesenhaGasolina()
        {
            if(TanqueGasolina > GasolinaInicial)
            {
                TanqueGasolina = GasolinaInicial;
            }
            for (int i = 0; i < TanqueGasolina; i++)
            {
                if(TanqueGasolina > GasolinaInicial /2 + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }else if(TanqueGasolina <= GasolinaInicial/2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if(TanqueGasolina <= GasolinaInicial/2-3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.SetCursorPosition(Program.Largura - 10, (Program.Altura - 4) - i);
                Console.Write(tanqueDeGasolina);
            }
        }
    }
}
