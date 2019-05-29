using System.Collections.Generic;

namespace Enduro_Marco_Lucas_TJD09
{
    public class EstadoCarro
    {
        protected List<char[,]> carroFrames;


        public abstract char[,] FrameDoCarro();

        public abstract int[,] PosiçãoDoCarro();

    }
}