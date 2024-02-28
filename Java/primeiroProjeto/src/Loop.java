import java.util.Scanner;

public class Loop {
    public static void main(String[] args) {
        Scanner leitura = new Scanner(System.in);
        double avaliacaoMedia = 0;
        double nota = 0;

        for (int i = 0; i < 3; i++) {
            System.out.printf("Diga sua avaliação para o filme:");
            nota= leitura.nextDouble();
            avaliacaoMedia += nota;
        }


        System.out.println("Media de Avaliação: " + avaliacaoMedia/3);
        
        
    }
}
