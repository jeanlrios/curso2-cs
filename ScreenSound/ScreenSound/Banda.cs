class Banda
{
    private List<Album> albums = new List<Album>();
    public string NomeBanda { get; set; }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {NomeBanda}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} (Duração total: {album.DuracaoTotal})");
        }
    }
}
