using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
        tab.ColacarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
        tab.ColacarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
        tab.ColacarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));





          Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}
