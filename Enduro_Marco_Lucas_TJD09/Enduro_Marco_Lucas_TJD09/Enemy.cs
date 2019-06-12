using System;

namespace Enduro_Marco_Lucas_TJD09
{
    class Enemy
    {
        Carro carroDoInimigo;
        ConsoleColor corDoCarro;
        Random random = new Random();
        public int PosX { get; private set; }
        public int PosY { get; private set; }


        public Enemy()
        {
            Array possibleColors = Enum.GetValues(typeof(ConsoleColor));
            ConsoleColor selectedColor = (ConsoleColor)possibleColors.GetValue(random.Next(possibleColors.Length));
            PosX = 0;
            PosY = 1;
            carroDoInimigo = new Carro(selectedColor, PosX, PosY);
        }

        private void MoveInimigo()
        {
            if (PosY < Program.Altura)
            {
                PosY++;
            }
        }

        public void DesenhaInimigo()
        {
            carroDoInimigo.MoveCarro(PosX,PosY);
            carroDoInimigo.DesenhaCarro();
        }
    }
}
