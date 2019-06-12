namespace Enduro_Marco_Lucas_TJD09
{
    class DesenhaPista
    {
        int larguraDaPista, comprimentoDaPista, meioDaPista;

        int frame = 0;
        public DesenhaPista()
        {
            //this.larguraDaPista = larguraDaPista;
            //this.comprimentoDaPista = comprimentoDaPista;
            //this.meioDaPista = meioDaPista;

        }

        public string[] DesenhaBordas(int larguraDaPista, int comprimentoDaPista, int meioDaPista)
        {
            frame++;
            string[] bufferLines = new string[Program.Altura - 1];
            for (int y = 0; y < bufferLines.Length; y++)
            {
                for (int x = 0; x < Program.Largura - 1; x++)
                {
                    if (x == (Program.Largura - larguraDaPista) / 2 + (comprimentoDaPista - y) - 5)
                    {
                        bufferLines[y] += '/';
                    }
                    else if (x == Program.Largura - meioDaPista)
                    {
                        if (frame % 2 == 0)
                        {
                            if (y % 2 == 0)
                            {
                                bufferLines[y] += '|';
                            }
                            else
                            {
                                bufferLines[y] += '\0';
                            }
                        }
                        else
                        {
                            if (y % 2 != 0)
                            {
                                bufferLines[y] += '|';
                            }
                            else
                            {
                                bufferLines[y] += '\0';
                            }
                        }

                    }
                    else if (x == Program.Largura - (Program.Largura - larguraDaPista) + y - 3)
                    {
                        bufferLines[y] += '\\';

                    }
                    else
                    {
                        bufferLines[y] += '\0';
                    }
                }
            }
            return bufferLines;
        }

        //public void DesenhaBordas(int larguraDaPista, int comprimentoDaPista, int meioDaPista)
        //{
        //    Console.Clear();
        //    frame++; // = ++frame % 2;
        //    for (int i = 0; i < comprimentoDaPista; i++)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.SetCursorPosition((Program.Largura - larguraDaPista) / 2 + i, Program.Altura - i);
        //        Console.Write('/');
        //        if (frame % 2 == 0)
        //        {
        //            if (i % 2 == 0)
        //            {

        //                Console.ForegroundColor = ConsoleColor.DarkYellow;
        //                Console.SetCursorPosition(Program.Largura - meioDaPista, Program.Altura - i);
        //                Console.Write('|');
        //            }
        //        }
        //        else 
        //        {
        //            if (i % 2 == 0)
        //            {

        //                Console.ForegroundColor = ConsoleColor.DarkYellow;
        //                Console.SetCursorPosition(Program.Largura - meioDaPista, Program.Altura - i - 1);
        //                Console.Write('|');
        //            }
        //        }
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.SetCursorPosition(Program.Largura - (Program.Largura - larguraDaPista) / 2 - i + 1, Program.Altura - i);
        //        Console.Write('\\');
        //    }
    }
}

