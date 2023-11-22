Album harrys = new Album();
harrys.Nome = "Harry's";

Musica musica1 = new Musica();
musica1.Nome = "Matilda";
musica1.Duracao = 200;

Musica musica2 = new Musica();
musica2.Nome = "Cinema";
musica1.Duracao = 300;

harrys.AdicionarMusica(musica1);
harrys.AdicionarMusica(musica2);

harrys.ExibirMusicasDoAlbum();