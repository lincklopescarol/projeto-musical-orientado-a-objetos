class Musica
{
    public Musica(Album artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; set; }
    public Album Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence ao álbum {Artista.Nome} da banda {Artista.Artista.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Álbum: {Artista.Nome}");
        Console.WriteLine($"Banda: {Artista.Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano plus!");
        }
    }
}