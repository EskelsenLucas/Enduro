using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    class DesenhaPista
    {
        int larguraDaPista, comprimentoDaPista, meioDaPista;

        int frame = 0;
        public DesenhaPista()
        {
            //this.larguraDaPista = larguraDaPista;
            //this.comprimentoDaPista = comprimentoDaPista;
            //this.meioDaPista = meioDaPista;

        }

        public void DesenhaBordas(int larguraDaPista, int comprimentoDaPista, int meioDaPista)
        {
            Console.Clear();
            frame++; // = ++frame % 2;
            for (int i = 0; i < comprimentoDaPista; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition((Program.Largura - larguraDaPista) / 2 + i, Program.Altura - i);
                Console.Write('/');
                if (frame % 2 == 0)
                {
                    if (i % 2 == 0)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(Program.Largura - meioDaPista, Program.Altura - i);
                        Console.Write('|');
                    }
                }
                else 
                {
                    if (i % 2 == 0)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(Program.Largura - meioDaPista, Program.Altura - i - 1);
                        Console.Write('|');
                    }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(Program.Largura - (Program.Largura - larguraDaPista) / 2 - i + 1, Program.Altura - i);
                Console.Write('\\');
            }
        }
    }
}
