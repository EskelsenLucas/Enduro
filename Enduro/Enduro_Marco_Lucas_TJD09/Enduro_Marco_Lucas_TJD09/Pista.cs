using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    public sealed class Pista
    {
        private static readonly Pista instance = new Pista();
        public int comprimentoDaPista, larguraDaPista, meioDaPista;
        public Pista()
        {
            comprimentoDaPista = Program.Altura;
            larguraDaPista = 60;
            meioDaPista = Program.Largura / 2;
        }

        public static Pista Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
