Banda queen = new Banda();
queen.NomeBanda = "Queen";

Album albumQueen = new Album();
albumQueen.Nome = "A Night at the Opera";

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

albumQueen.ExibirAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.AdicionarAlbum(albumQueen);
queen.ExibirDiscografia();


Podcast podcast = new Podcast("Jean Lucas", "ViagemCast");

Episodio episodio1 = new Episodio(01, "Conheça o novo podcast!", 130);
episodio1.AdicionarConvidados("João");
episodio1.AdicionarConvidados("Thiago");
Episodio episodio2 = new Episodio(02, "A vida de um engenheiro de software", 245);
episodio2.AdicionarConvidados("Guilherme");
episodio2.AdicionarConvidados("Marcos");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();
