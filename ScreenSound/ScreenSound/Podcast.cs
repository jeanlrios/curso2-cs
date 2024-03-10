class Podcast
{
    private List<Episodio> listaEpisodios = new List<Episodio>();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => listaEpisodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nBem vindos ao Podcast {Nome}, apresentado por {Host}\n");
        foreach(Episodio episodio in listaEpisodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nTotal de episodios: {TotalEpisodios}");
    }
}