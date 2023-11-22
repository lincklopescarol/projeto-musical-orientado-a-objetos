Musica musica1 = new Musica();

musica1.Nome = "Perfect";
musica1.Artista = "Ed Sheeran";
musica1.Duracao = 350;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel());

Musica musica2 = new Musica();
musica2.Nome = "Matilda";
musica2.Artista = "Harry Styles";
musica2.Duracao = 300;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel());

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
