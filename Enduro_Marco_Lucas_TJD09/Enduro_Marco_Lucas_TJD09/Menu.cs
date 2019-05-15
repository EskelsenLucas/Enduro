using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{

    class Menu
    {
        public string selecionarOpcao;
        //Jogo jogo = new Jogo();

        public void ListaMenu()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");//Centraliza menu
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                          Selecione uma opção");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                              1-  Start \n" +
                              "                              2- Options \n" +
                              "                              3-  Exit");
            selecionarOpcao = Console.ReadLine();
        }
    }
}
