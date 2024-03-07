import java.util.Scanner;

public class OutroLoop {
    public static void main(String[] args) {
        Scanner leitura = new Scanner(System.in);
        double avaliacaoMedia = 0;
        double nota = 0;
        int totalDeNotas = 0;

        while (nota != -1) {
            System.out.printf("Diga sua avaliação para o filme ou -1 para encerrar: ");
            nota = leitura.nextDouble();
            if(nota != -1) {
                avaliacaoMedia += nota;
                totalDeNotas++;
            }
        }

        if(totalDeNotas > 0) {
            System.out.println("Media de Avaliação: " + avaliacaoMedia / totalDeNotas);
        }

    }
}
