using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Enduro_Marco_Lucas_TJD09
{
    class Program
    {
        private const int largura = 101, altura = 30;
        private const int MF_BYCOMMAND = 0x00000000;
        //public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        public static int Largura { get { return largura; } }
        public static int Altura { get { return altura; } }


        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        static Jogo jogo = new Jogo();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                //prevents user from closing application
                //DeleteMenu(sysMenu, SC_CLOSE, MF_BYCOMMAND;
                //prevents user from minimizing application
                DeleteMenu(sysMenu, SC_MINIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
            }

            Console.BufferWidth = Console.WindowWidth = largura;

            jogo.CarregaMenu();
            //while (true)
            //{

            //}
        }
    }
}
