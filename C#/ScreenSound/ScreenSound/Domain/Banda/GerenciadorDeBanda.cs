namespace ScreenSound.Domain.Banda;

public class GerenciadorDeBanda : Public
{
    //List<string> listaDasBandas = new List<string>();

    Dictionary<string, List<int>> _bandasRegistradas = new Dictionary<string, List<int>>();

    public void RegistrarBanda()
    {
        Console.Write("Digite o nome da Banda que deseja cadastrar: ");
        var nomeBanda = Console.ReadLine()!;
        _bandasRegistradas.Add(nomeBanda, new List<int>());
        Console.WriteLine($"A Banda {nomeBanda} foi registrada com sucesso!");
    }

    public void ExibirBandasCadastradas()
    {
        var contador = 1;
        foreach (var banda in _bandasRegistradas.Keys)
        {
            Console.WriteLine($"{contador} - {banda}");
            contador++;
        }
    }

    public void AvaliarUmaBanda()
    {
        ExibirBandasCadastradas();
        Console.WriteLine(PularLinha);
        Console.Write("Digite O nome da banda você deseja avaliar: ");
        var bandaSelecionada = Console.ReadLine()!;

        if (BandaSelecionadaExiste(bandaSelecionada))
        {
            Console.Write($"Qual a nota que a banda {bandaSelecionada} merece: ");
            var nota = int.Parse(Console.ReadLine()!);
            _bandasRegistradas[bandaSelecionada].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {bandaSelecionada}");
        }
        else
        {
            Console.WriteLine($"A banda {bandaSelecionada} não foi encontrada!");
        }
    }

    private bool BandaSelecionadaExiste(string bandaSelecionada)
    {
        return _bandasRegistradas.ContainsKey(bandaSelecionada);
    }

    internal void ExibirMediaDaBanda()
    {
        ExibirBandasCadastradas();
        Console.WriteLine(PularLinha);
        Console.Write("Digite o nome da banda no qual deseja ver a média: ");
        var bandaSelecionada = Console.ReadLine();

        if (BandaSelecionadaExiste(bandaSelecionada))
        {
            var notas = _bandasRegistradas[bandaSelecionada];
            Console.WriteLine($"\nA Média da banda {bandaSelecionada} é: {notas.Average()}");
        }
        else {
            Console.WriteLine($"\nA banda {bandaSelecionada} não foi encontrada!");
        }
    }
}
