using System.Collections.Generic;

namespace Enduro_Marco_Lucas_TJD09
{
    public class EstadoCarro
    {
        protected int frameAtual = 0;
        protected List<char[,]> carroFrames;

        public EstadoCarro()
        {
        }

        public virtual char[,] FrameDoCarro()
        {
            frameAtual = ++frameAtual % carroFrames.Count;
            return carroFrames[frameAtual];
        }
    }
}