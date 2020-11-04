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
            Produto p = new Produto(codProduto, Qtd);
            this.CPF = CPF;
            this.codProduto = codProduto;
            this.Qtd = Qtd;
            this.cliente = cliente;
            this.codVenda = codVenda;
            valorVenda = p.GetQtd() * p.GetPreco();

        }

        public String GetCPF()
        {
            return CPF;
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

        public void SetCPF(String CPF)
        {
            this.CPF = CPF;
        }

        public void SetValorVenda(double Qtd)
        {
            this.valorVenda = Qtd;
        }
    }
}
