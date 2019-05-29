using System.Collections.Generic;

namespace Enduro_Marco_Lucas_TJD09
{
    public abstract class EstadoCarro
    {
        protected List<char[,]> carroFrames;

        public EstadoCarro()
        {
        }

        public virtual char[,] FrameDoCarro()
        {
            return null;
        }              
    }
}