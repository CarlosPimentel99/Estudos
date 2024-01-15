using ScreenSound;
using System.ComponentModel;

var _pularLinha = "\n";

// execução do programa
IniciarAplicacao();


void IniciarAplicacao()
{
    Console.Write(@"
░██████╗░█████╗░██████╗░███████╗███╗░░██╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.Write(_pularLinha);
    Console.WriteLine("Seja bem vindo ao Screen Sound!!!!");
    ExibirMenu();
}

void ExibirMenu()
{
    Console.Write(_pularLinha);
    foreach (Menu opcao in Enum.GetValues(typeof(Menu)))
    {
        string descricao = ObterDescricaoDoMenu(opcao);
        Console.WriteLine($"Digite {opcao.GetHashCode()} para {descricao}");
    }

    Console.Write(_pularLinha + "Digite a opção desejada: ");
    var opcaoEscolhida = int.Parse(Console.ReadLine()!);

    ValidarOpcaoDoMenuEscolhida(opcaoEscolhida);

}

string ObterDescricaoDoMenu(Menu opcao)
{
    var memberInfo = typeof(Menu).GetMember(opcao.ToString());
    var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(memberInfo[0], typeof(DescriptionAttribute));

    return descriptionAttribute?.Description ?? opcao.ToString();
}


static void ValidarOpcaoDoMenuEscolhida(int opcaoEscolhida)
{
    if (opcaoEscolhida == Menu.Sair.GetHashCode())
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    } else if (opcaoEscolhida == Menu.RegistrarUmaBanda.GetHashCode())
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else
    {
        Console.WriteLine("Nenhuma opção valida foi digitada!!!");
    }

}