using ScreenSound.Domain.MenuPrincipal;

public class Program
{
    private static void Main(string[] args) =>

        // execução do programa
        IniciarAplicacao();


    public static void IniciarAplicacao()
    {
        var gerenciadorMenu = new GerenciadorDeMenu();

        gerenciadorMenu.ExibirMenu();        
    }
}