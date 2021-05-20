﻿namespace tabuleiro
{
    abstract  class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get;protected set; }
        public int qtdMovimento { get;protected set; }
        public Tabuleiro tab { get; protected set; }

       public Peca(Tabuleiro tab,Cor cor) 
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimento = 0;        
        }
        public void imcrementaMovimento()
        {
            qtdMovimento++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPosiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public abstract bool[,] movimentosPosiveis();
       
        
    }
}
