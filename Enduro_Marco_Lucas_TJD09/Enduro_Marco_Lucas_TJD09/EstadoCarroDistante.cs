﻿using System.Collections.Generic;

namespace Enduro_Marco_Lucas_TJD09
{
    class EstadoCarroDistante : EstadoCarro
    {
        public EstadoCarroDistante()
        {
            carroFrames = new List<char[,]>//Frame 1
        {
            new char[,]
            {
                {'▄'}
            },
            new char[,] //Frame 2
            {
                {'▀'}
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

