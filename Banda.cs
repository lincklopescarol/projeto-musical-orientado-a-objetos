class Banda
{
    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:\n");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal} segundos)");
        }
    }
}


