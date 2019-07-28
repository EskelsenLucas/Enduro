using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{
    class Gasolina
    {
        string tanqueDeGasolina = "█████";
        public int GasolinaInicial = 12;
        public int TanqueGasolina;

        public void DesenhaGasolina()
        {
            if(TanqueGasolina > GasolinaInicial)
            {
                TanqueGasolina = GasolinaInicial;
            }
            for (int i = 0; i < TanqueGasolina; i++)
            {
                if(TanqueGasolina > GasolinaInicial /2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }else if(TanqueGasolina <= GasolinaInicial/2 && TanqueGasolina > 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if(TanqueGasolina <= GasolinaInicial/2-2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                int alturaGas = (Program.Altura - 4) - i;
                Console.SetCursorPosition(Program.Largura - 10, alturaGas);
                Console.Write(tanqueDeGasolina);
                Console.SetCursorPosition(Program.Largura - 10, alturaGas-=1);
                Console.WriteLine(" GAS");
            }
        }
    }
}
