using System.Collections.Generic;


namespace Enduro_Marco_Lucas_TJD09
{
    class EstadoCarroExplodindo : EstadoCarro
    {

        public EstadoCarroExplodindo()
        {
            carroFrames = new List<char[,]>//Frame 1
            {
            new char[,]
            {
                {'▄','╦','▄'},
                {'▄','╧','▄'}
            },
            new char[,] //Frame 2
            {
                {'▀','╦','▀'},
                {'▀','╧','▀'}
            },
        };
        }

        public override char[,] FrameDoCarro()
        {
            frameAtual = ++frameAtual % carroFrames.Count;
            return carroFrames[frameAtual];
        }

        //public EstadoCarroExplodindo()
        //{
        //    carroFrames = new List<char[,]>//Frame 1
        //    {
        //        new char[,]
        //        {
        //            {'*','x','*'},
        //            {'x','*','x'}
        //        },
        //        new char[,] //Frame 2
        //        {
        //            {'x','*','x'},
        //            {'*','x','*'}
        //        },
        //    };
        //}

        //public override char[,] FrameDoCarro()
        //{
        //    frameAtual = ++frameAtual % carroFrames.Count;
        //    return carroFrames[frameAtual];
        //}

    }
}

