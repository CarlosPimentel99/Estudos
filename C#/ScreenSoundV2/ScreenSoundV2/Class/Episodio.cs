namespace ScreenSoundV2.Classes
{
    public class Episodio
    {
        public int Duracao { get; set; }
        public int Ordem { get; set; }
        public string Resumo
        {
            get
            {
                return $"Episódio: {Ordem} \t " +
                        $"Titulo: {Titulo} \t " +
                        $"Duração: {Duracao} \t" +
                        $"Convidados: {string.Join("; ", ListaConvidados)}";
            }
        }

        public string Titulo { get; set; }

        public List<string> ListaConvidados { get; set; } = new List<string>();

        public void AdicionarConvidados(string convidado)
        {
            ListaConvidados.Add(convidado);
        }

    }
}
