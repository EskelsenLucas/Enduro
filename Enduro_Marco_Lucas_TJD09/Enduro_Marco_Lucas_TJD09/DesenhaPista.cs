using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{
    class DesenhaPista
    {
        int larguraDaPista, comprimentoDaPista, meioDaPista;


        public DesenhaPista()
        {
            //this.larguraDaPista = larguraDaPista;
            //this.comprimentoDaPista = comprimentoDaPista;
            //this.meioDaPista = meioDaPista;

        }

        public void DesenhaBordas(int larguraDaPista, int comprimentoDaPista, int meioDaPista)
        {
            for (int i = 0; i < comprimentoDaPista; i++)
            {
                Console.SetCursorPosition((Program.Largura - larguraDaPista) / 2 + i, Program.Altura - i);
                Console.Write('/');
                if (i % 2== 0)
                {
                    Console.SetCursorPosition(Program.Largura - meioDaPista, Program.Altura - i);
                    Console.Write('|');
                }
                Console.SetCursorPosition(Program.Largura - (Program.Largura - larguraDaPista) / 2 - i + 1, Program.Altura - i);
                Console.Write('\\');
            }
        }
    }
}
