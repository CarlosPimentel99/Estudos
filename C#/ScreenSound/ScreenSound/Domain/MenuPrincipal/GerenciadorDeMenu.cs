using ScreenSound.Domain.Banda;
using System.ComponentModel;

namespace ScreenSound.Domain.MenuPrincipal;

public class GerenciadorDeMenu : Public
{

    public GerenciadorDeBanda _gerenciadorDeBanda;

    public int DelayMenu
    {
        get
        {
            return 3000;
        }
    }

    public GerenciadorDeBanda GerenciadorBanda
    {
        get
        {
            if (_gerenciadorDeBanda is null)
                _gerenciadorDeBanda = new GerenciadorDeBanda();

            return _gerenciadorDeBanda;
        }
    }

    public void ExibirMenu()
    {
        ExibirLogoProjeto();
        Console.Write("\n");
        Console.WriteLine("Seja bem vindo ao Screen Sound!!!!");
        Console.Write(PularLinha);
        foreach (Menu opcao in Enum.GetValues(typeof(Menu)))
        {
            string descricao = ObterDescricaoDoMenu(opcao);
            Console.WriteLine($"Digite {opcao.GetHashCode()} para {descricao}");
        }

        Console.Write(PularLinha + "Digite a opção desejada: ");
        var opcaoEscolhida = int.Parse(Console.ReadLine()!);

        ValidarOpcaoDoMenuEscolhida(opcaoEscolhida);

    }

    private static void ExibirLogoProjeto()
    {
        Console.Write(@"
░██████╗░█████╗░██████╗░███████╗███╗░░██╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    }

    public string ObterDescricaoDoMenu(Menu opcao)
    {
        var memberInfo = typeof(Menu).GetMember(opcao.ToString());
        var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(memberInfo[0], typeof(DescriptionAttribute));

        return descriptionAttribute?.Description ?? opcao.ToString();
    }

    public void ValidarOpcaoDoMenuEscolhida(int opcaoEscolhida)
    {

        switch (opcaoEscolhida)
        {
            case 1:
                ExibirApresentacaoMenu("Registros de Bandas");
                GerenciadorBanda.RegistrarBanda();
                break;
            case 2:
                ExibirApresentacaoMenu("Bandas cadastradas");
                GerenciadorBanda.ExibirBandasCadastradas();
                break;
            case 3:
                ExibirApresentacaoMenu("Avaliar Bandas");
                GerenciadorBanda.AvaliarUmaBanda();
                break;
            case 4:
                ExibirApresentacaoMenu("Ver média das Bandas");
                GerenciadorBanda.ExibirMediaDaBanda();
                break;
            case -1:
                Console.WriteLine("Você escolheu a opção Sair, ATÉ MAIS :)");
                break;
            default:
                Console.WriteLine("Opção Inválida!!");
                break;
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }

    public void ExibirApresentacaoMenu(string titulo)
    {
        var quantidadeDeCaracteres = titulo.Length;
        var stringDeAsteriscos = String.Empty.PadLeft(quantidadeDeCaracteres, '*');

        Console.Clear();
        ExibirLogoProjeto();
        Console.WriteLine(PularLinha);
        Console.WriteLine(stringDeAsteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(stringDeAsteriscos);
        Console.WriteLine(PularLinha);
    }
}
