using System;
using System.Threading;


namespace Enduro_Marco_Lucas_TJD09
{
    class Carro
    {

        public int carX, carY;
        int estadoAtual = 2;
        ConsoleColor carColor;
        EstadoCarro[] EstadoAtualDoCarro = new EstadoCarro[4];

        public Carro(ConsoleColor Color = ConsoleColor.Red, int posX = 50, int posY = 25)
        {
            carX = posX;
            carY = posY;
            carColor = Color;
            EstadoAtualDoCarro[0] = new EstadoCarroDistante();
            EstadoAtualDoCarro[1] = new EstadoCarroMedio();
            EstadoAtualDoCarro[2] = new EstadoCarroProximo();
            EstadoAtualDoCarro[3] = new EstadoCarroExplodindo();

        }

        public void DesenhaCarro()
        {
            //ConsoleKeyInfo teclaApertada = Console.ReadKey();
            //switch (teclaApertada.Key)
            //{
            //    case ConsoleKey.LeftArrow:
            //        carX -= 1;
            //        break;
            //    case ConsoleKey.RightArrow:
            //        carX += 1;
            //        break;
            //    case ConsoleKey.UpArrow:
            //        carY -= 1;
            //        break;
            //    case ConsoleKey.DownArrow:
            //        carY += 1;
            //        break;
            //}


            for (int y = 0; y < EstadoAtualDoCarro[StateChanger()].FrameDoCarro().GetLength(1); y++)
            {
                for (int x = 0; x < EstadoAtualDoCarro[StateChanger()].FrameDoCarro().GetLength(0); x++)
                {
                    Console.SetCursorPosition(carX + y, carY + x);
                    Console.ForegroundColor = carColor;
                    Console.Write(EstadoAtualDoCarro[StateChanger()].FrameDoCarro()[x, y]);
                    //Console.Write(frame[x, y]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void MoveCarro(int direcaoX = 0, int direcaoY = 0)
        {
            carX += direcaoX;
            carY += direcaoY;
        }

        private int StateChanger()
        {
            int intervaloDeDistancia = Program.Altura / 3;

            if (carY > intervaloDeDistancia)
            {
                if (carY > intervaloDeDistancia * 2)
                {
                    return 2;
                }
                return 1;
            }
            return 0;
        }
    }
}
