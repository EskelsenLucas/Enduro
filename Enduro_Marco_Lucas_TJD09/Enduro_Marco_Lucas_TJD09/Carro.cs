using System;
using System.Threading;


namespace Enduro_Marco_Lucas_TJD09
{
    class Carro
    {

        int carX, carY;
        int estadoAtual = 2;
        ConsoleColor carColor;
        EstadoCarro[] EstadoAtualDoCarro = new EstadoCarro[4];

        public Carro(ConsoleColor Color, int posX = 50, int posY = 25)
        {
            carX = posX;
            carY = posY;
            carColor = Color;
            EstadoAtualDoCarro[0] = new EstadoCarroDistante();
            EstadoAtualDoCarro[1] = new EstadoCarroMedio();
            EstadoAtualDoCarro[2] = new EstadoCarroProximo();
            EstadoAtualDoCarro[3] = new EstadoCarroExplodindo();


        }


        int posXCarro, posYCarro;


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
                case ConsoleKey.UpArrow:
                    posYCarro -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    posYCarro += 1;
                    break;
            }


            for (int y = 0; y < EstadoAtualDoCarro[StateChanger()].FrameDoCarro().GetLength(1); y++)
            {
                for (int x = 0; x < EstadoAtualDoCarro[StateChanger()].FrameDoCarro().GetLength(0); x++)
                {
                    Console.SetCursorPosition(carX + posXCarro + y, carY + posYCarro + x);
                    Console.ForegroundColor = carColor;
                    Console.Write(EstadoAtualDoCarro[StateChanger()].FrameDoCarro()[x, y]);
                    //Console.Write(frame[x, y]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private int StateChanger()
        {
            int intervaloDeDistancia = Program.Altura / 3;

            if (carY + posYCarro > intervaloDeDistancia)
            {
                if (carY + posYCarro > intervaloDeDistancia * 2)
                {
                    return 2;
                }
                return 1;
            }
            return 0;
        }
    }
}
