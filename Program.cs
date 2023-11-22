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
        Console.WriteLine(ep1.Resumo);
    }
}