public class Condicional {
    public static void main(String[] args) {
        int anoLançamento = 1990;
        boolean incluidoNoPlano = true;
        double notaDoFilme = 8.1;

        String tipoPlano = "Plus";

        if(anoLançamento >= 2022)
        {
            System.out.printf("Lançamentos que os clientes estão curtindo!");
        }else {
            System.out.printf("Filme retro que vale a pena assistir!");
        }

        if(incluidoNoPlano || tipoPlano.equals("Plus")){
            System.out.printf("Filme Liberado");
        }else{
            System.out.printf("Deve pagar a locação");
        }



    }
}
