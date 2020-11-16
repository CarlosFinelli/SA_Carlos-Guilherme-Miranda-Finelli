using System;
using System.Collections.Generic;
using System.Linq;

namespace SA_Carlos_Guilherme_Miranda_Finelli
{
    class Program
    {
        static void Main(string[] args)
        {
            Venda v = new Venda();
            List<Cliente> C = new List<Cliente>();
            List<Produto> P = new List<Produto>();
            List<Venda> V = new List<Venda>();
            List<Venda> list = new List<Venda>();
            int opcao, decisao;
            double result;
        inicio:
            Console.Clear();

            Console.WriteLine(" _____________________________________________________________________");
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
            Console.WriteLine("|_____________________________________________________________________|");
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
                    Console.Write("Insira o CPF do cliente: ");
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
                    Console.Write("Insira o CPF do cliente: ");
                    CPF = Console.ReadLine();
                    Console.Clear();
                    Cliente cli = C.Find(cli => cli.CPF == CPF);
                    if (cli == null)
                    {
                        Console.WriteLine("CPF inválido");
                        Console.ReadKey();
                        goto case 2;
                    }
                    foreach(var item in P)
                    {
                        Console.WriteLine($"|{item.GetCodProduto()} = {item.GetNomeProduto()} | Preço = {item.GetPreco()}|");
                        Console.WriteLine();
                    }
                    Console.Write("Insira o código do produto que deseja comprar: ");
                    int codProduto = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    Produto pro = P.Find(pro => pro.GetCodProduto() == codProduto);
                    if (pro == null)
                    {
                        Console.WriteLine("Código do produto inválido");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 2;
                    }
                    Console.Write("Insira a quantidade que deseja comprar desse produto: ");
                    int Qtd = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    if (pro.GetQtd() < Qtd)
                    {
                        Console.WriteLine("A quantidade que deseja comprar é maior que a nossa quantidade em estoque.");
                        Console.WriteLine();
                        Console.Write("Gostaria de comprar a quantidade disponível em nosso estoque? (1 = Sim, 2 = Não): ");
                        opcao = Convert.ToInt16(Console.ReadLine());
                        if (opcao == 1)
                        {
                            pro.SetQtd(pro.GetQtd() * 0);
                        } 
                        if (opcao == 2)
                        {
                            Console.Clear();
                            goto inicio;
                        }
                    } else
                    {
                        pro.SetQtd(pro.GetQtd() - Qtd);
                    }
                    int codVen = 0;
                    foreach(var item in V)
                    {
                        codVen = item.GetCodVenda();
                    }
                    codVen++;
                    Venda venda = new Venda(CPF, pro, Qtd, cli, codVen);
                    venda.SetValorVenda(pro.GetPreco() * Qtd);
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
                        cod = item.GetCodProduto();
                    }
                    cod++;
                    Produto produto = new Produto(nomeProduto, Qtd, cod, preco);
                    P.Add(produto);
                    Console.Clear();
                    Console.Write("Deseja inserir mais algum produto? (1 - Sim, 2 - Não): ");
                    decisao = Convert.ToInt16(Console.ReadLine());
                    while (decisao != 2)
                    {
                        Console.Clear();
                        goto case 3;
                    }
                    goto inicio;

                case 4:
                    double contv = 0;
                    foreach(var item in V)
                    {
                        contv += item.GetValorVenda();
                    }
                    result = contv / V.Count;
                    Console.WriteLine($"A média dos valores das vendas é igual a: {result}");
                    Console.ReadKey();
                    goto inicio;

                case 5:
                    foreach(var item in V)
                    {
                        if (item.GetValorVenda() > v.GetValorVenda())
                        {
                            v.SetValorVenda(item.GetValorVenda());
                            v.SetCodVenda(item.GetCodVenda());
                        }
                        v.SetMaxValor(V);
                    }
                    Console.Write($"Código da venda: {v.GetCodVenda()} | Valor da Venda: {v.GetValorVenda()}");
                    Console.ReadKey();
                    goto inicio;

                case 6:
                    v.SetMaxValor(V);
                    v.SetValorVenda(v.GetValorMax());
                    foreach (var item in V)
                    {
                        if (item.GetValorVenda() < v.GetValorVenda())
                        {
                            v.SetValorVenda(item.GetValorVenda());
                            v.SetCodVenda(item.GetCodVenda());
                        }
                    }
                    Console.Write($"Código da venda: {v.GetCodVenda()} | Valor da Venda: {v.GetValorVenda()}");
                    Console.ReadKey();
                    goto inicio;

                case 7:
                    int total, resultado = 0, codi = 0;
                    for (int i = 1; i < P.Count; i++)
                    {
                        var bacon = V.FindAll(V => V.GetProduto().GetCodProduto() == i);
                        total = bacon.Sum(V => V.GetQtd());
                        if (total > resultado)
                        {
                            resultado = total;
                            codi = i;
                        }
                    }
                    Console.WriteLine($"| Código do produto mais vendido: {codi} | Quantidade total vendida: {resultado} |");
                    Console.ReadKey();
                    goto inicio;

                case 8:
                    total = 0; resultado = 0; codi = 0;
                    for (int i = 1; i < P.Count; i++)
                    {
                        var bacon = V.FindAll(V => V.GetProduto().GetCodProduto() == i);
                        total = bacon.Sum(V => V.GetQtd());
                        if (total < resultado)
                        {
                            resultado = total;
                            codi = i;
                        }
                        resultado = total;
                    }
                    Console.WriteLine($"| Código do produto menos vendido: {codi} | Quantidade total vendida: {resultado} |");
                    Console.ReadKey();
                    goto inicio;

                case 9:
                    list = new List<Venda>();
                    Console.Write("Isira o CPF que deseja: ");
                    CPF = Console.ReadLine();
                    Console.Clear();
                    cli = C.Find(cli => cli.CPF == CPF);
                    foreach (var item in V)
                    {
                        if (cli.CPF == item.GetCliente().CPF)
                        {
                            list.Add(item);
                        }
                    }
                    foreach(var item in list)
                    {
                        Console.WriteLine($"|Código de venda: {item.GetCodVenda()} | Nome Cliente: {item.GetCliente().nome} | CPF cliente: {item.GetCliente().CPF} | Código do produto: {item.GetProduto().GetCodProduto()}" +
                            $" | Quantidade comprada: {item.GetQtd()} | \n|Valor da compra: {item.GetValorVenda()}|");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"Total de compras: {list.Count}");
                    Console.ReadKey();
                    goto inicio;

                case 10:
                    list = new List<Venda>();
                    Console.WriteLine("Insira o código do produto que deseja verificar: ");
                    int CodProduto = Convert.ToInt16(Console.ReadLine());
                    pro = P.Find(pro => pro.GetCodProduto() == CodProduto);
                    foreach (var item in V)
                    {
                        if (pro.GetCodProduto() == item.GetProduto().GetCodProduto())
                        {
                            list.Add(item);
                        }
                    }
                    foreach(var item in list)
                    {
                        Console.WriteLine($"|Código da venda: {item.GetCodVenda()} | Produto vendido: {item.GetProduto().GetCodProduto()} - {item.GetProduto().GetNomeProduto()} | " +
                            $"| Quantidade comprada: {item.GetProduto().GetQtd()} | Valor da venda: {item.GetValorVenda()}");
                    }
                    Console.ReadKey();
                    goto inicio;

                case 11:
                    result = 0;
                    foreach (var item in V)
                    {
                        result += item.GetValorVenda();
                    }
                    Console.WriteLine($"Saldo final: {result}");
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
