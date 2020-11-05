using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Carlos_Guilherme_Miranda_Finelli
{
    class Produto
    {
        private String nomeProduto;
        private int codProduto, qtd;
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

        public double GetPreco()
        {
            return preco;
        }

        public String GetNomeProduto()
        {
            return nomeProduto;
        }

        public int GetCodProduto()
        {
            return codProduto;
        }

        public int GetQtd()
        {
            return qtd;
        }

        public void SetQtd(int Qtd)
        {
            this.qtd = Qtd;
        }
    }
}
