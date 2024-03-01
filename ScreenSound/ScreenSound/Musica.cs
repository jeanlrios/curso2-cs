class Musica
{
    public string Nome;
    public string Artista;
    public int Duracao;
    public bool Disponivel;

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
}

