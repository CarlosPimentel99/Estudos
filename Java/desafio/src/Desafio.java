import java.util.Scanner;

public class Desafio {
    public static void main(String[] args) {
        String nome = "Tony Stark";
        String tipoConta = "Corrente";
        double saldo = 1599.99;

        System.out.println("****************************");
        System.out.println("\nNome do cliente: "+ nome);
        System.out.println("Tipo conta: " + tipoConta);
        System.out.println("Saldo atual: " + saldo);
        System.out.println("\n****************************");

        int opcao = 0;
        String menu = """
                ** Digite sua opção **
                1 - Consultar Saldo
                2 - Fazer PIX
                3 - Receber valor
                4 - Sair
                
                """;

        Scanner leitura = new Scanner(System.in);

        while(opcao != 4){
            System.out.println(menu);
            opcao = leitura.nextInt();
        }
    }
}
