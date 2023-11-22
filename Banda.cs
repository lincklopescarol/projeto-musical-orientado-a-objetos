class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Discografia da banda {Nome}: {album.Nome} ({album.DuracaoTotal} segundos)");
        }
    }
}

