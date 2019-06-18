using System;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    public sealed class Jogo
    {
        Menu menu = new Menu();
        public Pista pista = Pista.Instance;
        DesenhaPista bordas = new DesenhaPista();
        HUD hud = new HUD();
        Gasolina gasolina = new Gasolina();
        ConsoleColor corEscolhidaCarro = ConsoleColor.White;
        private string[] buffer = new string[Program.Altura];
        Player jogador;
        Enemy inimigo;

        bool estaJogando = false;

        int contadorGasolina = 0;

        public string[] Buffer
        {
            get { return buffer; }
            set { buffer = value; }
        }


        public void CarregaMenu()
        {
            estaJogando = false;
            Console.Clear();
            menu.SelecionarOpcao = "0";
            menu.ListaMenu(corEscolhidaCarro);
            OpcoesMenu();
        }

        void OpcoesMenu()
        {
            Console.Clear();
            if (menu.SelecionarOpcao == "1")
            {
                estaJogando = true;
                IniciaJogo();
            }
            else if (menu.SelecionarOpcao == "2")
            {
                menu.CentralizaStrings("Escolha uma cor para o carro: ", 10, ConsoleColor.DarkCyan);
                menu.CentralizaStrings("1- Azul | 2- Verde | 3- Vermelho | 4- Magenta | 5- Branco", 11, ConsoleColor.Yellow);
                menu.SelecionarOpcao = Console.ReadLine();
                switch (menu.SelecionarOpcao)
                {
                    case "1":
                        corEscolhidaCarro = ConsoleColor.Blue;
                        break;
                    case "2":
                        corEscolhidaCarro = ConsoleColor.Green;
                        break;
                    case "3":
                        corEscolhidaCarro = ConsoleColor.Red;
                        break;
                    case "4":
                        corEscolhidaCarro = ConsoleColor.Magenta;
                        break;
                    case "5":
                        corEscolhidaCarro = ConsoleColor.White;
                        break;
                }
                Console.Clear();
                CarregaMenu();
            }
            else if (menu.SelecionarOpcao == "3")//Fecha o jogo
            {
                Environment.Exit(0);
            }
            else if (menu.SelecionarOpcao == "4")
            {
                Console.Clear();
                menu.CentralizaStrings("Marco A. Filipe & Lucas G. E. Vogtmannsberger", 12, ConsoleColor.Yellow);
                Console.ReadLine();
                CarregaMenu();
            }
            else if (menu.SelecionarOpcao == "5")
            {
                Console.Clear();
                menu.CentralizaStrings("Pontuação mais alta: ", 12, ConsoleColor.Yellow);
                menu.CentralizaStrings(hud.pontuacaoJogador.ToString(), 13, ConsoleColor.White);
                Console.ReadLine();
                CarregaMenu();
            }
            else //Se digitar uma opção que é inválida
            {
                menu.CentralizaStrings("Selecione uma opção válida!", 10, ConsoleColor.Red);
                Thread.Sleep(800);
                Console.Clear();
                CarregaMenu();
            }
        }

        public void IniciaJogo()
        {
            //Carro carro = new Carro(corEscolhidaCarro);
            jogador = new Player(corEscolhidaCarro);
            inimigo = new Enemy();
            while (estaJogando)
            {
                Console.Clear();
                LimpaBuffer();
                Buffer = bordas.DesenhaBordas(pista.larguraDaPista, pista.comprimentoDaPista, pista.meioDaPista);
                for (int y = 0; y < buffer.Length; y++)
                {
                    Console.WriteLine(buffer[y]);
                }
                hud.InterfaceHUD();
                gasolina.DesenhaGasolina();
                contadorGasolina++;
                if(contadorGasolina >= 25)
                {
                    gasolina.TanqueGasolina-= 2;
                    contadorGasolina = 0;
                }
                inimigo.DesenhaInimigo();
                jogador.DesenhaJogador();
                CollisionCheck(jogador.RelayPosition(), inimigo.RelayPosition());
                JogoAcabou();
                //inimigo.CarroDoInimigo.CarExplosion();
                Console.SetCursorPosition(0, Program.Altura - 1);
                Thread.Sleep(66);
            }
        }

        private void JogoAcabou()
        {
            if (gasolina.TanqueGasolina <= 0)
            {
                menu.CentralizaStrings("Fim de Jogo", Program.Altura/2, ConsoleColor.Red);
                Thread.Sleep(1000);
                CarregaMenu();
            }
        }

        private void CollisionCheck(Tuple<int, int> playerCoord, Tuple<int, int> enemyCoord)
        {
            if (playerCoord.Item2 >= enemyCoord.Item2 - 2 && playerCoord.Item2 <= enemyCoord.Item2 + 2)
            {
                if (playerCoord.Item1 >= enemyCoord.Item1 - 2 && playerCoord.Item1 <= enemyCoord.Item1 + 2)
                {
                    inimigo.CarroDoInimigo.CarExplosion();
                    Console.BackgroundColor = ConsoleColor.Red;
                    hud.pontuacaoJogador++;
                    gasolina.TanqueGasolina++;
                }
            }
        }

        private void LimpaBuffer()
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = string.Empty;
            }
        }
    }
}
