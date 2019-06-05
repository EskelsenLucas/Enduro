using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{
    class Player
    {
        Carro carroDoPlayer;
        ConsoleColor corDoCarro;

        public Player(ConsoleColor corDoCarro)
        {
            this.corDoCarro = corDoCarro;
            carroDoPlayer = new Carro(corDoCarro);
        }

        public int MoveCarro()
        {
            return LeInputDoJogador().Item1;
        }


        public int AceleraCarro()
        {
            return LeInputDoJogador().Item2;
        }

        public Tuple<int,int> LeInputDoJogador()
        {
            int x = 0, y = 0;
            ConsoleKeyInfo teclaApertada = Console.ReadKey();

            switch (teclaApertada.Key)
            {
                case ConsoleKey.LeftArrow:
                    x = -1;
                    break;
                case ConsoleKey.A:
                    x = -1;
                    break;
                case ConsoleKey.RightArrow:
                    x = 1;
                    break;
                case ConsoleKey.D:
                    x = 1;
                    break;
                case ConsoleKey.UpArrow:
                    y = +6;
                    break;
                case ConsoleKey.W:
                    y = +6;
                    break;
                case ConsoleKey.DownArrow:
                    y = -6;
                    break;
                case ConsoleKey.S:
                    y = -6;
                    break;
                default:
                    x = 0;
                    y = 0;
                    break;
            }

            return Tuple.Create(x,y);
        }

        public void DesenhaJogador()
        {
            carroDoPlayer.MoveCarro(MoveCarro());
            carroDoPlayer.DesenhaCarro();
        }
    }
}
