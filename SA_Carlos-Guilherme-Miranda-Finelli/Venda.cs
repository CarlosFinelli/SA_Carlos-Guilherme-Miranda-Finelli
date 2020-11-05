using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SA_Carlos_Guilherme_Miranda_Finelli
{
    class Venda
    {
        private String CPF;
        private int codProduto, codVenda, Qtd;
        private double SaldoFinal, valorVenda;
        private Cliente cliente;

        public Venda()
        {

        }
        public Venda(String CPF, int codProduto, int Qtd, Cliente cliente, int codVenda)
        {
            this.CPF = CPF;
            this.codProduto = codProduto;
            this.Qtd = Qtd;
            this.cliente = cliente;
            this.codVenda = codVenda;
        }

        public int GetCodProduto()
        {
            return codProduto;
        }

        public int GetQtd()
        {
            return Qtd;
        }
        public int GetCodVenda()
        {
            return codVenda;
        }
        
        public double GetSaldoFinal()
        {
            return SaldoFinal;
        }

        public double GetValorVenda()
        {
            return valorVenda;
        }
        public Cliente GetCliente()
        {
            return cliente;
        }

        public void SetValorVenda(double ValorVenda)
        {
            this.valorVenda = ValorVenda;
        }

        public void SetCodVenda(int CodVenda)
        {
            this.codVenda = CodVenda;
        }

        public void SetQtd(int Qtd)
        {
            this.Qtd = Qtd;
        }
    }
}
