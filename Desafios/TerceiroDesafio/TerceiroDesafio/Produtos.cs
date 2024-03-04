// 2. Desenvolver uma classe que represente um estoque de
// produtos, e que tenha as funcionalidades de adicionar
// novos produtos, e exibir todos os produtos no estoque.
using System.Xml;

class Produtos
{      
    public string Nome { get; set; }
    public string Marca { get; set; }
    private double preco;
    private int quantidade;
    public double Preco { get => preco;
        set
        {
            if(value > 0)
            {
                preco = value;
            } else
            {
                preco = 10;
            }
        }  
    }
    public int Quantidade
    {
        get => quantidade;
        set
        {
            if(value > 0)
            {
                quantidade = value;
            }
            else
            {
                quantidade = 0;
            }
        }
    }
    public string Descricao =>
        $"Produto: {Nome}\nMarca: {Marca}\nPreco: R${Preco}\nDisponiveis: {Quantidade}\n";
}
