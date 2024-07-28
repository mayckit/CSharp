using System;
using System.Collections.Generic;
using ProjectProducts;


    List<Produto> produtos = new List<Produto>();
    Produto product = new Produto();


        int opcao;
        do{
            opcao = Menu();

            switch (opcao){
                case 1:
                    Produto produto = new Produto();
                    produto.AdicionarProduto();
                    produtos.Add(produto);
                    break;
                case 2:
                    product.ListarProdutos(produtos);
                    break;
                case 3:
                    product.EditarProduto(produtos);
                    break;
                case 4:
                    product.PesquisarProduto(produtos);
                    break;
                case 5:
                    product.ListarProdutosComEstoqueBaixo(produtos);
                    break;
                case 6:
                    product.ApagarProduto(produtos);
                    break;
                case 0:
                    Console.WriteLine("Saindo e salvando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    

    static int Menu(){
        Console.WriteLine("=====> ESTOQUE DE PRODUTOS <=====");
        Console.WriteLine("1 - Cadastrar um novo Produto");
        Console.WriteLine("2 - Listar todos os produtos");
        Console.WriteLine("3 - Editar dados de um produto");
        Console.WriteLine("4 - Pesquisar um produto");
        Console.WriteLine("5 - Listar produtos com estoque inferior a 10");
        Console.WriteLine("6 - Apagar um produto");
        Console.WriteLine("0 - Sair e Salvar");
        int opcao = int.Parse(Console.ReadLine());
        return opcao;
    }

