using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{
    class Jogo
    {
        Menu menu = new Menu();
        Pista pista = new Pista(Program.Altura, Program.Largura);
        DesenhaPista bordas = new DesenhaPista();
        Carro carro = new Carro(ConsoleColor.Red, 10, 5);

        public void CarregaMenu()
        {
            menu.ListaMenu();
            OpcoesMenu();
        }

        void OpcoesMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");//Centraliza menu
            if (menu.selecionarOpcao == "1")
            {
                IniciaJogo();
            }
            else if (menu.selecionarOpcao == "2")
            {
                Console.WriteLine("                         Digite um tamanho de fonte \n" +
                                  "                             16 | 20 | 24 | 28");
                menu.selecionarOpcao = Console.ReadLine();
                Console.Clear();
                CarregaMenu();
            }
            else if (menu.selecionarOpcao == "3")
            {
                //Fecha o jogo
            }
            else //Se digitar uma opção que é inválida
            {
                Console.WriteLine("                         Selecione uma opção válida!");
                Console.ReadLine();
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
            }
        }
    }
}
