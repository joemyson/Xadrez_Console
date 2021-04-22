
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas{ get; set; }
        private Peca[,] pecas;
 
        public Tabuleiro( int linhas ,int colunas) 
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];      
        
        }
        public Peca peca(int linhas,int colunas)
        {

            return pecas[linhas, colunas];
        }

        public Peca peca (Posicao pos) 
        {
            return pecas[pos.linha, pos.coluna];
        
        }
        public void ColacarPeca(Peca p,Posicao pos) 
        {
            if (existePeca(pos)) 
            {
                throw new TabuleiroException("ja existe uma peça nesta posição");
            
            }

            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;        
        }
        public bool posicaoValida(Posicao pos) 
        {
        if(pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna >= colunas) 
            {
                return false;
            
            }
            return true;        
        
        }
        public void validarTabuleiro(Posicao pos)
        {

            if (!posicaoValida(pos)) 
            {
                throw new TabuleiroException("posicão invalida");
            }
        }
        public bool existePeca(Posicao pos) 
        {
            posicaoValida(pos);
            return peca(pos) != null;
        }


    }
}
