// 5. Modelar um sistema para um restaurante com classes como Restaurante,
// Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem
// ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos
// podem estar associados a uma mesa.
class ProdutosRestaurante
{
    public string NomePrato { get; set; }
    public double PrecoPrato { get; set; }
    public string NomeBebida { get; set; }
    public double PrecoBebida { get; set; }
    public string PratosCardapio =>
        $"Prato: {NomePrato}\n Preco: {PrecoPrato}";
    public string BebidasCardapio =>
        $"Bebida: {NomeBebida}\n Preco: {PrecoBebida}";
}