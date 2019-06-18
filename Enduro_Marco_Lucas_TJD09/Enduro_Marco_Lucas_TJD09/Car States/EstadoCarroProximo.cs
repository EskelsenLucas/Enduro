using System.Collections.Generic;

namespace Enduro_Marco_Lucas_TJD09
{
    public class EstadoCarroProximo : EstadoCarro
    {

        public EstadoCarroProximo()
        {
            carroFrames = new List<char[,]>//Frame 1
            {
            new char[,]
            {
                {'m','╦','m'},
                {'w','╧','w'}
            },
            new char[,] //Frame 2
            {
                {'w','╦','w'},
                {'m','╧','m'}
            },
        };
        }

        public override char[,] FrameDoCarro()
        {
            frameAtual = ++frameAtual % carroFrames.Count;
            return carroFrames[frameAtual];
        }
    }
}