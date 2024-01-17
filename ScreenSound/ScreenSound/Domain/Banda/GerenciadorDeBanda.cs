namespace ScreenSound.Domain.Banda;

public class GerenciadorDeBanda
{
    public void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("Registros de Bandas");
        Console.Write("Digite o nome da Banda que deseja cadastrar: ");
        var nomeBanda = Console.ReadLine()!;

        Console.WriteLine($"A Banda {nomeBanda} foi registrada com sucesso!");
    }
}
