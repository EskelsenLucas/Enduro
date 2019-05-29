using System;
using System.Collections.Generic;

namespace Enduro_Marco_Lucas_TJD09
{
    //chara

    class Carro
    {

        int frameAtual;
        int carX, carY;
        ConsoleColor carColor;

        public Carro(ConsoleColor Color = ConsoleColor.White, int posX = 50, int posY = 25)
        {
            carX = posX;
            carY = posY;
            carColor = Color;
        }

        public List<char[,]> carroFrames = new List<char[,]>//Frame 1
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
        int posXCarro;

        ConsoleKeyInfo teclaApertada;

        public void DesenhaCarro()
        {
            switch (teclaApertada.Key)
            {
                case ConsoleKey.LeftArrow:
                    posXCarro -= 1;
                    break;
            }

            frameAtual = ++frameAtual % carroFrames.Count;
            var frame = carroFrames[frameAtual];


            for (int y = 0; y < carroFrames[frameAtual].GetLength(1); y++)
            {
                for (int x = 0; x < carroFrames[frameAtual].GetLength(0); x++)
                {
                    Console.SetCursorPosition(carX + posXCarro + y, carY + x);
                    Console.ForegroundColor = carColor;
                    Console.Write(frame[x, y]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
