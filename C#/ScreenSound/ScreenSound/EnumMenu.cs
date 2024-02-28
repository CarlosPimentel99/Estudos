using System.ComponentModel;

namespace ScreenSound;

public enum Menu
{
    [Description("Registrar uma Banda")]
    RegistrarUmaBanda = 1,

    [Description("Mostrar todas as Bandas")]
    MostrarTodasAsBandas = 2,

    [Description("Avaliar uma Banda")]
    AvaliarUmaBanda = 3,

    [Description("Exibir média de uma Banda")]
    ExibirMediaDeUmaBanda = 4,

    [Description("Sair")]
    Sair = -1
}
