using System;
using System.Threading;


namespace Enduro_Marco_Lucas_TJD09
{
    class Carro
    {

        int carX, carY;
        int estadoAtual = 2;
        ConsoleColor carColor;
        EstadoCarro[] EstadoAtualDoCarro = new EstadoCarro[3];

        public Carro(ConsoleColor Color, int posX = 50, int posY = 25)
        {
            carX = posX;
            carY = posY;
            carColor = Color;
            EstadoAtualDoCarro[0] = new EstadoCarroDistante();
            EstadoAtualDoCarro[1] = new EstadoCarroMedio();
            EstadoAtualDoCarro[2] = new EstadoCarroProximo();

        }


        int posXCarro;


        public void DesenhaCarro()
        {
            ConsoleKeyInfo teclaApertada = Console.ReadKey();
            switch (teclaApertada.Key)
            {
                case ConsoleKey.LeftArrow:
                    posXCarro -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    posXCarro += 1;
                    break;
            }

            for (int y = 0; y < EstadoAtualDoCarro[estadoAtual].FrameDoCarro().GetLength(1); y++)
            {
                for (int x = 0; x < EstadoAtualDoCarro[estadoAtual].FrameDoCarro().GetLength(0); x++)
                {
                    Console.SetCursorPosition(carX + posXCarro + y, carY + x);
                    Console.ForegroundColor = carColor;
                    Console.Write(EstadoAtualDoCarro[estadoAtual].FrameDoCarro()[x, y]);
                    //Console.Write(frame[x, y]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
