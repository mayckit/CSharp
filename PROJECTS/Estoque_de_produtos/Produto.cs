using System;
using System.Collections.Generic;
namespace ProjectProducts{  

public class Produto{
    private int Codigo { get; set; }
    private string Nome { get; set; }
    private double Preco { get; set; }
    private int Quantidade { get; set; }

    public Produto(){  }

    public void AdicionarProduto(){

        Console.WriteLine("Digite o código do produto:");
        Codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome do produto:");
        Nome = Console.ReadLine();
        Console.WriteLine("Digite o preço do produto:");
        Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade do produto:");
        Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Produto adicionado!!");
    }

    public void ListarProdutos(List<Produto> produtos){

        Console.WriteLine("=====> LISTA DE PRODUTOS <=====");
        foreach (Produto produto in produtos){
            Console.WriteLine(produto);
            Console.WriteLine("----------------------------------");
        }
    }

    public void EditarProduto(List<Produto> produtos)
    {
        Console.WriteLine("Digite o código do produto que deseja editar:");
        int codigoedit = int.Parse(Console.ReadLine());

        Produto newproduto = produtos.Find(p => p.Codigo == codigoedit);

        if (newproduto != null){
            Console.WriteLine("Digite o novo nome do produto:");
            newproduto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o novo preço do produto:");
            newproduto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nova quantidade do produto:");
            newproduto.Quantidade = int.Parse(Console.ReadLine());
        }else{
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public void PesquisarProduto(List<Produto> produtos){

        Console.WriteLine("Digite o código do produto para pesquisa:");
        int codigo = int.Parse(Console.ReadLine());

        Produto produto = produtos.Find(p => p.Codigo == codigo);

        if (produto != null){
            Console.WriteLine(produto);
        }else{
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public void ListarProdutosComEstoqueBaixo(List<Produto> produtos){

        Console.WriteLine("=====> PRODUTOS COM ESTOQUE INFERIOR A 10 <=====");

        foreach (Produto produto in produtos.FindAll(p => p.Quantidade < 10)){
            Console.WriteLine(produto);
        }
    }

    public void ApagarProduto(List<Produto> produtos){

        Console.WriteLine("Digite o código do produto que deseja apagar:");
        int codigo = int.Parse(Console.ReadLine());
        Produto produto = produtos.Find(p => p.Codigo == codigo);

        if (produto != null){
            produtos.Remove(produto);
            Console.WriteLine("Produto apagado!");
        }else{
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public override string ToString()
    {
        return $"Código: {Codigo}, Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
    }
}



}