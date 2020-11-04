using System;
using System.Collections.Generic;

namespace SA_Carlos_Guilherme_Miranda_Finelli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> C = new List<Cliente>();
            List<Produto> P = new List<Produto>();
            List<Venda> V = new List<Venda>();
            int opcao, decisao;
        inicio:
            Console.Clear();
            Console.WriteLine("|---------------------------------------------------------------------|");
            Console.WriteLine("|                         1 - Manter clientes                         |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         2 - Manter venda                            |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         3 - Manter produtos                         |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         4 - Média de vendas                         |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         5 - Maior venda                             |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         6 - Menor venda                             |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         7 - Produto mais vendido                    |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         8 - Produto menos vendido                   |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         9 - Vendas por cliente                      |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                        10 - Vendas por produto                      |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                        11 - Saldo final                             |");
            Console.WriteLine("|                                                                     |");
            Console.WriteLine("|                         0 - Sair                                    |");
            Console.WriteLine("|---------------------------------------------------------------------|");
            Console.WriteLine();
            Console.Write("Selecione uma opção: ");
            opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    Console.Write("Insira o nome do cliente: ");
                    String nome = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Insira o cpf do cliente: ");
                    String CPF = Console.ReadLine();
                    Console.Clear();
                    Cliente cliente = new Cliente(nome, CPF);
                    C.Add(cliente);
                    Console.Write("Deseja inserir mais algum cliente? (1 - Sim, 2 - Não): ");
                    decisao = Convert.ToInt16(Console.ReadLine());
                    while (decisao != 2)
                    {
                        Console.Clear();
                        goto case 1;
                    }
                    goto inicio;

                case 2:
                    Console.WriteLine("Insira o CPF do cliente: ");
                    CPF = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Insira o código do produto: ");
                    int codProduto = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Insira a quantidade que deseja comprar desse produto: ");
                    int Qtd = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    Cliente cli;
                    int ven = 0;
                    cli = C.Find(cli => cli.CPF == CPF);
                    foreach(var item in V)
                    {
                        ven = item.GetCodVenda();
                    }
                    Venda venda = new Venda(CPF, codProduto, Qtd, cli, ven++);
                    V.Add(venda);
                    Console.Write("Deseja inserir mais alguma venda? (1 - Sim, 2 - Não): ");
                    decisao = Convert.ToInt16(Console.ReadLine());
                    while (decisao != 2)
                    {
                        Console.Clear();
                        goto case 2;
                    }
                    goto inicio;

                case 3:
                    Console.Write("Insira o nome do produto: ");
                    String nomeProduto = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Insira a quantidade de produtos comprada: ");
                    Qtd = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Insira o preço unitário desse produto: ");
                    double preco = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    int cod = 0;
                    foreach(var item in P)
                    {
                        cod = item.codProduto;
                    }
                    Produto produto = new Produto(nomeProduto, Qtd, cod++, preco);
                    P.Add(produto);
                    Console.Write("Deseja inserir mais algum produto? (1 - Sim, 2 - Não): ");
                    decisao = Convert.ToInt16(Console.ReadLine());
                    while (decisao != 2)
                    {
                        Console.Clear();
                        goto case 3;
                    }
                    goto inicio;

                case 4:
                    Console.ReadKey();
                    goto inicio;

                case 5:
                    Venda v = new Venda();
                    foreach(var item in V)
                    {
                        if (item.GetValorVenda() > v.GetValorVenda())
                        {
                            v.SetValorVenda(item.GetValorVenda());
                            v.SetCodVenda(item.GetCodVenda());
                        }
                    }
                    Console.WriteLine($"Código da venda: {v.GetCodVenda()} | Valor da Venda: {v.GetValorVenda()}");
                    Console.ReadKey();
                    goto inicio;

                case 6:
                    Console.ReadKey();
                    goto inicio;

                case 7:
                    Console.ReadKey();
                    goto inicio;

                case 8:
                    Console.ReadKey();
                    goto inicio;

                case 9:
                    foreach(Venda item in V)
                    {
                        Console.WriteLine(item.GetCPF());
                    }
                    Console.ReadKey();
                    goto inicio;

                case 10:
                    Console.ReadKey();
                    goto inicio;

                case 11:
                    foreach (var item in P)
                    {
                        Console.WriteLine(item.codProduto);
                    }
                    Console.ReadKey();
                    goto inicio;

                case 0:
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
