using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{
    class HUD
    {
        public int pontuacaoJogador;

        public void InterfaceHUD()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5 , Program.Altura - (Program.Altura - 2));
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" Pontos: {0} ",pontuacaoJogador);
            Console.ResetColor();
        }
    }
}
