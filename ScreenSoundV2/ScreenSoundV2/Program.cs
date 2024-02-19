using ScreenSoundV2.Classes;
using System.Reflection;

var banda = new Banda(nome: "Queen");


var albumDoQueen = new Album(nome: "A night at the opera");

var musica1 = new Musica(banda, nome: "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};

var musica2 = new Musica(banda, nome: "Bohemiam Rhapsody")
{
    Duracao = 354,
    Disponivel = false 
};

albumDoQueen.AdicionaMusica(musica1);
albumDoQueen.AdicionaMusica(musica2 );

banda.AdicionarAlbum(albumDoQueen);
banda.ExibirDiscografia();

Console.WriteLine("=================================================================");


var podcast = new Podcast(host: "ServidorLocal", nome: "Um maluco no pedaço");

var episodio1 = new Episodio()
{
    Duracao = 3000,
    Ordem = 1,
    Titulo = "O inicio de tudo"
};

episodio1.AdicionarConvidados("Will Smith");

var episodio2 = new Episodio()
{
    Duracao = 3000,
    Ordem = 2,
    Titulo = "O inicio de tudo parte2"
};

episodio2.AdicionarConvidados("Will Smith");
episodio2.AdicionarConvidados("Freddie Mercury");

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);

podcast.ExibirDetalhes();