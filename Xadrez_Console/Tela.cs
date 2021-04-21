﻿using tabuleiro;
using System;

namespace Xadrez_Console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        { 
        
        for (int i=0;i < tab.linhas; i++)
            {
                for(int j = 0; i < tab.colunas; i++)
                {
                    if (tab.peca(i, j) == null) 
                    {
                        Console.Write("- ");               
                    
                    
                    }
                    else 
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
            }
        
        
        }
    }
}
