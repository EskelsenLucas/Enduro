﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            Console.Write(" Pontos: {0}        ",pontuacaoJogador);
            Console.SetCursorPosition(5, Program.Altura - (Program.Altura - 3));
            Console.Write(" (1000 pontos para ganhar) ");
            Console.ResetColor();
            if(pontuacaoJogador >= 1000)
            {
                Console.SetCursorPosition(Program.Largura / 2, Program.Altura / 2);
                Console.Write("ACABOU");
                pontuacaoJogador = 0;
            }
        }
    }
}
