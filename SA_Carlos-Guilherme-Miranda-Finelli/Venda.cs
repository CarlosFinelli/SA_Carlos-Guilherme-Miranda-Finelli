using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace SA_Carlos_Guilherme_Miranda_Finelli
{
    class Venda
    {
        private String CPF;
        private int codVenda, Qtd;
        private double SaldoFinal, valorVenda, valorMax;
        private Cliente cliente;
        private Produto produto;

        public Venda()
        {

        }
        public Venda(String CPF, Produto produto, int Qtd, Cliente cliente, int codVenda)
        {
            this.CPF = CPF;
            this.produto = produto;
            this.Qtd = Qtd;
            this.cliente = cliente;
            this.codVenda = codVenda;
        }

        public Produto GetProduto()
        {
            return produto;
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

        public double GetValorMax()
        {
            return valorMax;
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

        public void SetMaxValor(List<Venda> V)
        {
            foreach (var item in V)
            {
                if (item.GetValorVenda() > GetValorVenda())
                {
                    SetValorVenda(item.GetValorVenda());
                    SetCodVenda(item.GetCodVenda());
                    valorMax = item.GetValorVenda();
                }
            }
        }

        public void SetSaldoFinal(double SaldoFinal)
        {
            this.SaldoFinal = SaldoFinal;
        }
    }
}
