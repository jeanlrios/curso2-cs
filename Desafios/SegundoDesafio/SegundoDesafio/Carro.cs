// 2. Reescrever os atributos da classe Carro, de modo que
// eles sejam properties, e adicionar uma nova
// propertie DescricaoDetalhada, que mostra o
// fabricante, modelo e ano do carro.
class Carro
{
    public string ModeloCarro { get; set; }
    public string CorCarro { get; set; }
    public string FabricanteCarro { get; set; }
    // 3. Reescrever a propriedade Ano da classe carro, para
    // que ela apenas aceite valores entre 1960 e 2023.
    private int AnoCarro;
    public int Ano
    {
        get => AnoCarro;
        set
        {
            if(value < 1960 || value > 2023)
            {
                Console.WriteLine("O ano de fabricação deve estar entre 1960 e 2023");
            } else
            {
                AnoCarro = value;
            }
        }
    }    
    public string DescricaoDetalhada =>
        $"Carro {FabricanteCarro} {ModeloCarro}, ano {Ano}, cor {CorCarro}.";
}