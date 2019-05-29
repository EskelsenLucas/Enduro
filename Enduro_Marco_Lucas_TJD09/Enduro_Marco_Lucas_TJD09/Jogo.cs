﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    class Jogo
    {
        Menu menu = new Menu();
        Pista pista = new Pista(Program.Altura, Program.Largura);
        DesenhaPista bordas = new DesenhaPista();
        HUD hud = new HUD();
        Carro carro = new Carro();

        ConsoleColor corEscolhidaCarro = ConsoleColor.White;

        public void CarregaMenu()
        {
            menu.ListaMenu();
            OpcoesMenu();
        }

        void OpcoesMenu()
        {
            Console.Clear();
            if (menu.SelecionarOpcao == "1")
            {
                IniciaJogo();
            }else if (menu.SelecionarOpcao == "2")
            {
                menu.CentralizaStrings("Escolha uma cor para o carro: ", 10, ConsoleColor.DarkCyan);
                menu.CentralizaStrings("1- Azul | 2- Verde | 3- Vermelho | 4- Magenta | 5- Branco", 11, ConsoleColor.Yellow);
                menu.SelecionarOpcao = Console.ReadLine();
                Console.Clear();
                CarregaMenu();
            }else if (menu.SelecionarOpcao == "3")//Fecha o jogo
            {
                
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
            while (true)
            {
                bordas.DesenhaBordas(pista.larguraDaPista, pista.comprimentoDaPista, pista.meioDaPista);
                carro.DesenhaCarro();
                hud.InterfaceHUD();
                Thread.Sleep(66);
            }
        }
    }
}
