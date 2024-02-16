using ScreenSoundV2.Classes;
using System.Reflection;

var banda = new Banda(nome: "Queen");


var albumDoQueen = new Album(nome: "A night at the opera");

var musica1 = new Musica(banda, nome: "Love of my life");
musica1.Duracao = 213;

var musica2 = new Musica(banda, nome: "Bohemiam Rhapsody");
musica2.Duracao = 354;

albumDoQueen.AdicionaMusica(musica1);
albumDoQueen.AdicionaMusica(musica2 );

banda.AdicionarAlbum(albumDoQueen);
banda.ExibirDiscografia();