using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{

    class Menu
    {
        public string SelecionarOpcao;
        int posAlturaMenu = 1, posLarguraMenu = 1;
        #region string menu
        string logoJogoMenu = "\n\n\n                                   ▄▄▄▄ ▄▄▄  ▄ ▄▄▄  ▄  ▄ ▄▄▄▄ ▄▄▄▄\n" +
                                    "                                   █▄▄  █ █  █ █  █ █  █ █  █ █  █\n" +
                                    "                                   █    █  █ █ █  █ █  █ █▀▀▄ █  █\n" +
                                    "                                   ▀▀▀▀ ▀  ▀▀▀ ▀▀▀  ▀▀▀▀ ▀  ▀ ▀▀▀▀\n";
        #endregion

        public void ListaMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(logoJogoMenu);
            CentralizaStrings("Selecione uma opção", 10, ConsoleColor.DarkCyan);
            CentralizaStrings("1-  Iniciar | 2- Opções | 3-  Sair", 11, ConsoleColor.Yellow);
            CentralizaStrings("Cor do carro: ", 15, ConsoleColor.White);  
            SelecionarOpcao = Console.ReadLine();
        }

        //Função para centralizar strings (não pode passar de 100 char)
        public void CentralizaStrings(string textoParaCentralizar, int EscolhaUmaAltura, ConsoleColor cor)
        {
            posLarguraMenu = (Program.Largura - textoParaCentralizar.Length) / 2;
            posAlturaMenu = EscolhaUmaAltura; //(Program.Altura / 2) - 5;
            Console.ForegroundColor = cor;
            Console.SetCursorPosition(posLarguraMenu, posAlturaMenu);
            Console.WriteLine(textoParaCentralizar);
        }
    }
}
