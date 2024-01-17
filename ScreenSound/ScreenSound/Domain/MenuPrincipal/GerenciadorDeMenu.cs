using ScreenSound.Domain.Banda;
using System.ComponentModel;

namespace ScreenSound.Domain.MenuPrincipal;

public class GerenciadorDeMenu : Public
{

    public void ExibirMenu()
    {
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

    public string ObterDescricaoDoMenu(Menu opcao)
    {
        var memberInfo = typeof(Menu).GetMember(opcao.ToString());
        var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(memberInfo[0], typeof(DescriptionAttribute));

        return descriptionAttribute?.Description ?? opcao.ToString();
    }

    public void ValidarOpcaoDoMenuEscolhida(int opcaoEscolhida)
    {

        var gerenciadorDeBanda = new GerenciadorDeBanda();

        switch (opcaoEscolhida)
        {
            case 1:
                gerenciadorDeBanda.RegistrarBanda();
                Thread.Sleep(5000);
                Console.Clear();
                ExibirMenu();
                break;
            case 2:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                break;
            case 3:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                break;
            case 4:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                break;
            case -1:
                Console.WriteLine("Você escolheu a opção Sair, ATÉ MAIS :)");
                break;
            default:
                Console.WriteLine("Opção Inválida!!");
                break;
        }

    }
}
