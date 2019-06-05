using System;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    class Player
    {
        Carro carroDoPlayer;
        ConsoleColor corDoCarro;
        Thread inputReader;


        public Player(ConsoleColor corDoCarro)
        {
            this.corDoCarro = corDoCarro;
            carroDoPlayer = new Carro(corDoCarro);
            inputReader = new Thread(new ThreadStart(inputtroll));
            inputReader.Start();
        }
              

        void inputtroll()
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
                    carroDoPlayer.MoveCarro(-1, 0);
                    break;
                case ConsoleKey.A:
                    carroDoPlayer.MoveCarro(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    carroDoPlayer.MoveCarro(1, 0);
                    break;
                case ConsoleKey.D:
                    carroDoPlayer.MoveCarro(1, 0);
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
            carroDoPlayer.DesenhaCarro();
        }


    }
}
