using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Carlos_Guilherme_Miranda_Finelli
{
    class Produto
    {
        public String nomeProduto;
        public int codProduto, qtd;
        private double preco;

        public Produto(String nomeProduto, int qtd, int codProduto, double preco)
        {
            this.codProduto = codProduto;
            this.nomeProduto = nomeProduto;
            this.qtd = qtd;
            this.preco = preco;
        }

        public Produto(int codProduto, int qtd)
        {
            this.qtd -= qtd;
        }
    }
}
