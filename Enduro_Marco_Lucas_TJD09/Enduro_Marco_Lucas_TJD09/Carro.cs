using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enduro_Marco_Lucas_TJD09
{
    //chara

    class Carro
    {
        public List<char[,]> carro = new List<char[,]>()//Frame 1
        { 
            {'▄','╦','▄'},
            {'▄','╬','▄'}
        };
        char[,] carro2 = new char[,] //Frame 2
        {
            {'▀','╦','▀'},
            {'▀','╬','▀'}
        };
        int posXCarro;

        ConsoleKeyInfo teclaApertada;

        public void DesenhaCarro()
        {
            switch (teclaApertada.Key)
            {
                case ConsoleKey.LeftArrow:
                    posXCarro -= 1;
                    break;
            }
            Console.SetCursorPosition((Program.Largura / 2 )+ 1 + posXCarro, 25);
            //Console.Write();
            
        }
    }
}
