class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A musica {Nome} pertence a banda {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.NomeBanda}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano!\n");
        } else
        {
            Console.WriteLine("Assine o plano para ouvir está música\n");
        }
    }
    public void ExibirArtistaNome()
    {
        Console.WriteLine($"Nome: {Nome} - Artista: {Artista}");
    }
}

