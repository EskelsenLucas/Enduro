using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    class Player
    {
        Carro carroDoPlayer;
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        ConsoleColor corDoCarro;
        public Thread inputReader;


        public Player(ConsoleColor corDoCarro)
        {
            this.corDoCarro = corDoCarro;
            PosX = 50;
            PosY = 25;
            carroDoPlayer = new Carro(corDoCarro);
            inputReader = new Thread(new ThreadStart(InputThreadMethod));
            inputReader.Start();
        }


        void InputThreadMethod()
        {
            while (true)
            {
                LeInputDoJogador();
            }
        }

        public void LeInputDoJogador()
        {
            ConsoleKeyInfo teclaApertada = Console.ReadKey();

            switch (teclaApertada.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (PosX > (Program.Largura - Pista.Instance.larguraDaPista) / 2 + (Pista.Instance.comprimentoDaPista - PosY) - 4)
                    {
                        PosX--;
                    }
                    break;
                case ConsoleKey.A:
                    if (PosX > (Program.Largura - Pista.Instance.larguraDaPista) / 2 + (Pista.Instance.comprimentoDaPista - PosY) - 4)
                    {
                        PosX--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (PosX < Program.Largura - (Program.Largura - Pista.Instance.larguraDaPista) + PosY - 6)
                    {
                        PosX++;
                    }
                    break;
                case ConsoleKey.D:
                    if (PosX < Program.Largura - (Program.Largura - Pista.Instance.larguraDaPista) + PosY - 6)
                    {
                        PosX++;
                    }
                    break;
                //case ConsoleKey.UpArrow:
                //    y = -6;
                //    break;
                //case ConsoleKey.W:
                //    y = -6;
                //    break;
                //case ConsoleKey.DownArrow:
                //    y = 6;
                //    break;
                //case ConsoleKey.S:
                //    y = 6;
                //    break;
                default:
                    break;
            }
            while (Console.KeyAvailable)
                Console.ReadKey(true);
        }

        public void DesenhaJogador()
        {
            carroDoPlayer.MoveCarro(PosX, PosY);
            carroDoPlayer.DesenhaCarro();
        }

        public Tuple<int, int> RelayPosition()
        {
            return Tuple.Create(PosX, PosY);
        }
    }
}
