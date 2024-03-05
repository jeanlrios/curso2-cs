Banda queen = new Banda();
queen.NomeBanda = "Queen";

Album albumQueen = new Album();
albumQueen.Nome = "A Night at the Opera";

Musica musica1 = new Musica(queen);
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica(queen);
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;


albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

albumQueen.ExibirAlbum();


queen.AdicionarAlbum(albumQueen);
queen.ExibirDiscografia();