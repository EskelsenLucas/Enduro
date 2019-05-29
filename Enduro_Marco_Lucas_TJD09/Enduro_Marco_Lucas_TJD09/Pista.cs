using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    class Pista
    {
        public int comprimentoDaPista, larguraDaPista, meioDaPista;
        public Pista(int alturaDaTela, int larguraDaTela)
        {
            comprimentoDaPista = alturaDaTela;
            larguraDaPista = 60;
            meioDaPista = larguraDaTela / 2;
        }
    }
}
