// 2. Desenvolver uma classe que represente um estoque de
// produtos, e que tenha as funcionalidades de adicionar
// novos produtos, e exibir todos os produtos no estoque.
class Estoque
{
    private List<Produtos> produtos = new List<Produtos>();
    public void AdicionarProduto(Produtos produto)
    {
        produtos.Add(produto);
        Console.WriteLine($"Produto: {produto.Nome} - Adicionado");
    }
    public void ExibirProdutos()
    {
        if(produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto encontrado.");
        } else
        {
            Console.WriteLine("Produtos no estoque:\n");
            foreach(var produto in produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}