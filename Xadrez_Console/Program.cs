using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColacarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
                tab.ColacarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                tab.ColacarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 0));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}
