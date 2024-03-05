class Musica
{
    public Musica(Banda artista)
    {
        Artista = artista;
    }
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A musica {Nome} pertence a banda {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
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

