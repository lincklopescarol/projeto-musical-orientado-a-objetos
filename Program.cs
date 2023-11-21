Musica musica1 = new Musica();

musica1.nome = "Perfect";
musica1.artista = "Ed Sheeran";
musica1.duracao = 350;
musica1.EscreveDisponivel(true);
Console.WriteLine(musica1.LeDisponivel());

Musica musica2 = new Musica();
musica2.nome = "Matilda";
musica2.artista = "Harry Styles";
musica2.duracao = 300;
musica1.EscreveDisponivel(false);
Console.WriteLine(musica1.LeDisponivel());

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
