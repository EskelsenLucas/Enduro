using System;

namespace Enduro_Marco_Lucas_TJD09
{
    class Enemy
    {
        public Carro CarroDoInimigo { get; private set; }
        ConsoleColor corDoCarro;
        Random random = new Random();
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        private int DestinationX;
        Array possibleColors;


        public Enemy()
        {
            possibleColors = Enum.GetValues(typeof(ConsoleColor));
            corDoCarro = (ConsoleColor)possibleColors.GetValue(random.Next(possibleColors.Length));
            PosX = random.Next((Program.Largura - Pista.Instance.larguraDaPista) / 2 + (Pista.Instance.comprimentoDaPista - PosY) - 4, Program.Largura - (Program.Largura - Pista.Instance.larguraDaPista) + PosY - 6);
            DestinationX = random.Next(Program.Largura - (Program.Largura - Pista.Instance.larguraDaPista) - 6);
            PosY = 0;
            CarroDoInimigo = new Carro(corDoCarro, PosX, PosY);
        }

        ~Enemy()
        {
            CarroDoInimigo.CarExplosion();
        }

        private void MoveInimigo()
        {
            if (PosY < Program.Altura - 1)
            {
                PosY++;

                if (PosX != DestinationX)
                {
                    PosX += (DestinationX - PosX) / (Pista.Instance.comprimentoDaPista - PosY);
                }
            }
            else
            {
                PosY = 0;
                PosX = random.Next((Program.Largura - Pista.Instance.larguraDaPista) / 2 + (Pista.Instance.comprimentoDaPista - PosY) - 4, Program.Largura - (Program.Largura - Pista.Instance.larguraDaPista) + PosY - 6);
                DestinationX = random.Next((Program.Largura - Pista.Instance.larguraDaPista) / 2 - 4, Program.Largura - (Program.Largura - Pista.Instance.larguraDaPista) - 6) + ((Program.Largura - Pista.Instance.larguraDaPista) / 2);
                corDoCarro = (ConsoleColor)possibleColors.GetValue(random.Next(possibleColors.Length));
                CarroDoInimigo = new Carro(corDoCarro, PosX, PosY);
            }
        }

        public void DesenhaInimigo()
        {
            MoveInimigo();
            CarroDoInimigo.MoveCarro(PosX, PosY);
            CarroDoInimigo.DesenhaCarro();
        }

        public Tuple<int, int> RelayPosition()
        {
            return Tuple.Create(PosX, PosY);
        }
    }
}
