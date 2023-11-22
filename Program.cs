class Program
{
    static void Main()
    {
        Banda oneD = new Banda("One D");

        Album harrys = new Album("Harry's", oneD);
        oneD.AdicionarAlbum(harrys);

        Musica musica1 = new Musica(harrys, "Matilda")
        {
            Duracao = 200,
            Disponivel = true,
        };

        Musica musica2 = new Musica(harrys, "Cinema")
        {
            Duracao = 300,
            Disponivel = false,
        };

        harrys.AdicionarMusica(musica1);
        harrys.AdicionarMusica(musica2);

        musica1.ExibirFichaTecnica();
        Console.WriteLine();
        musica2.ExibirFichaTecnica();

        Console.WriteLine();
        oneD.ExibirDiscografia();

        Episodio ep1 = new(1, "Como viver melhor", 45);
        ep1.AdicionarConvidados("Maria");
        

        Episodio ep2 = new(2, "Como estar em paz", 30);
        ep2.AdicionarConvidados("Fernanda");
       
       Podcast podcast = new ("Podcast", "João");
       podcast.AdicionarEpisodio(ep1);
       podcast.AdicionarEpisodio(ep2);
        podcast.ExibirDetalhes();
    }
}