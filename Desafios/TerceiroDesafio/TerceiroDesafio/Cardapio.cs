// 5. Modelar um sistema para um restaurante com classes como Restaurante,
// Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem
// ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos
// podem estar associados a uma mesa.
class Cardapio
{
    private List<ProdutosRestaurante> pratosRestaurantes = new List<ProdutosRestaurante>();
    private List<ProdutosRestaurante> bebidasRestaurantes = new List<ProdutosRestaurante>();
    public void AdicionarPratos(ProdutosRestaurante prato)
    {
        pratosRestaurantes.Add(prato);
    }

    public void AdicionarBebidas(ProdutosRestaurante bebida)
    {
        bebidasRestaurantes.Add(bebida);
    }
    public void ExibirPratos()
    {
        foreach(var prato in  pratosRestaurantes)
        {
            Console.WriteLine(prato.PratosCardapio);
        }
    }
    public void ExibirBebidas()
    {
        foreach(var bebida in bebidasRestaurantes)
        {
            Console.WriteLine(bebida.BebidasCardapio);
        }
    }
}