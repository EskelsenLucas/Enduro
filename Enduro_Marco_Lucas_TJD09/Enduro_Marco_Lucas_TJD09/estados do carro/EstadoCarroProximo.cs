using System.Collections.Generic;

namespace Enduro_Marco_Lucas_TJD09
{
    public class EstadoCarroAndando : EstadoCarro
    {

        int frameAtual;

        public EstadoCarroAndando()
        {
            carroFrames = new List<char[,]>//Frame 1
        {
            new char[,]
            {
                {'▄','╦','▄'},
                {'▄','╬','▄'}
            },
            new char[,] //Frame 2
            {
                {'▀','╦','▀'},
                {'▀','╬','▀'}
            },
        };
        }

        public override char[,] FrameDoCarro()
        {
            int frameAtual = ++frameAtual % carroFrames.Count;
            return carroFrames[frameAtual];
        }
    }
}