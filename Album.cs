class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome, Banda artista)
    {
        Nome = nome;
        Artista = artista;
    }

    public string Nome { get; set; }
    public Banda Artista { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome} da banda {Artista.Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse álbum, você precisa de {DuracaoTotal} segundos.");
    }
}