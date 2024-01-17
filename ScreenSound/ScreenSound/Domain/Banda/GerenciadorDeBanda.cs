namespace ScreenSound.Domain.Banda;

public class GerenciadorDeBanda : Public
{
    List<string> listaDasBandas = new List<string>();
    
    public void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("Registros de Bandas");
        Console.Write("Digite o nome da Banda que deseja cadastrar: ");
        var nomeBanda = Console.ReadLine()!;
        listaDasBandas.Add(nomeBanda);

        Console.WriteLine($"A Banda {nomeBanda} foi registrada com sucesso!");
    }

    public void ExibirBandasCadastradas()
    {
        Console.Clear();
        Console.WriteLine("Bandas cadastradas");
        foreach(var banda in listaDasBandas)
        {
            Console.WriteLine($"Banda: {banda}");
        }
    }
}
