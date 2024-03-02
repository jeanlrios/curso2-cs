// 4. Desenvolver a classe Produto, com os atributos
// nome, marca, preco e estoque. Além disso, garantir
// que o preço e o estoque do produto sejam valores
// positivos e criar uma propriedade que mostra detalhadamente
// as informações do produto, para que seja usado pela equipe de vendas.
class Produto
{
    public string nome;
    public string marca;
    private double preco;
    public double PrecoDisponivel { get => preco;
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
    private int estoque;
    public int Quantidade { get => estoque; 
        set
        {
            if(value > 0)
            {
                estoque = value;
            } else
            {
                estoque = 0;
            }
        } 
    }
    public string InfoProduto =>
        $"Produto: {nome}\nMarca: {marca}\nPreço: R${preco}\nEstoque: {estoque}\n";

}