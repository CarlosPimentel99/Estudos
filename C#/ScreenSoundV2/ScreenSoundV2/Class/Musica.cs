using ScreenSoundV2.Classes;

public class Musica
{

    public string Nome { get; }
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => Nome + " - " + Artista;

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano Free.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus para ouvir esta Música");
        }
    }
}