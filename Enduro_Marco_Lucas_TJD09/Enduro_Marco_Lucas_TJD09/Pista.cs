using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Enduro_Marco_Lucas_TJD09
{
    class Pista
    {
        #region Teste de Pista 1
        //string pistaDeCorrida = "|";
        //string buffer = string.Empty;
        //int ladoDireito = 65, ladoEsquerdo = 15;
        //int alturaDaPista = 30;
        //Random numeroAleatorio = new Random();

        //public void DesenhaPista()
        //{
        //    int geraCurva = numeroAleatorio.Next(0, 21);
        //    Thread.Sleep(10);
        //    //if(geraCurva <= 0)
        //    //{
        //        PistaReta();
        //    //}
        //    //else if (geraCurva >= 20)
        //    //{
        //        //CurvaParaEsquerda();
        //    //}
        //}

        //void PistaReta()
        //{
        //    Console.SetCursorPosition(ladoDireito, alturaDaPista);//Desenha o lado direito
        //    Console.WriteLine(pistaDeCorrida);
        //    Console.SetCursorPosition(ladoEsquerdo, alturaDaPista);//Desenha o lado esquerdo
        //    Console.WriteLine(pistaDeCorrida);
        //    alturaDaPista -= 1;
        //    ladoDireito -= 1;
        //    ladoEsquerdo += 1;
        //    if (ladoDireito >= 75 || ladoEsquerdo <= 0 || alturaDaPista <= 8)
        //    {
        //        Console.Clear();
        //        ladoDireito = 65;
        //        ladoEsquerdo = 15;
        //        alturaDaPista = 30;
        //    }
        //}

        //void CurvaParaEsquerda()
        //{
        //    alturaDaPista = 30;
        //    Console.SetCursorPosition(ladoEsquerdo, alturaDaPista);//Desenha o lado esquerdo
        //    Console.WriteLine(pistaDeCorrida);
        //    Console.SetCursorPosition(ladoDireito, alturaDaPista);//Desenha o lado direito
        //    Console.WriteLine(pistaDeCorrida);
        //    if (alturaDaPista >= 21)
        //    {
        //        alturaDaPista -= 1;
        //        ladoDireito -= 1;
        //        ladoEsquerdo += 1;
        //    }
        //    else if (alturaDaPista <= 20)
        //    {
        //        alturaDaPista -= 1;
        //        ladoEsquerdo -= 1;
        //        ladoDireito -= 1;
        //    }
        //}
        #endregion
        #region Teste de Pista 2

        public int comprimentoDaPista, larguraDaPista, meioDaPista;
        public Pista(int alturaDaTela, int larguraDaTela)
        {
            comprimentoDaPista = alturaDaTela;
            larguraDaPista = 60;
            meioDaPista = larguraDaTela / 2;
        }


        #endregion
    }
}
