using System;
using System.Collections.Generic;


namespace Enduro_Marco_Lucas_TJD09
{
    class Carro
    {

        int carX, carY;
        ConsoleColor carColor;
        EstadoCarro EstadoAtualDoCarro = new EstadoCarroAndando();

        public Carro(ConsoleColor Color = ConsoleColor.White, int posX = 50, int posY = 25)
        {
            carX = posX;
            carY = posY;
            carColor = Color;
        }

       
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

            for (int y = 0; y < EstadoAtualDoCarro.FrameDoCarro().GetLength(1); y++)
            {
                for (int x = 0; x < EstadoAtualDoCarro.FrameDoCarro().GetLength(0); x++)
                {
                    Console.SetCursorPosition(carX + posXCarro + y, carY + x);
                    Console.ForegroundColor = carColor;
                    Console.Write(EstadoAtualDoCarro.FrameDoCarro()[x, y]);
                    //Console.Write(frame[x, y]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
