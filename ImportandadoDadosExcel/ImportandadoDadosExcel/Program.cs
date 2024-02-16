using OfficeOpenXml;

class Progam
{
    static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        string caminhoArquivo = @"C:\Users\carlos.pimentel\Documents\Integrações\Migrações RS\TabelaDeParaOracle.xlsx";

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Arquivo não encontrado no caminho: " + caminhoArquivo);
            return;
        }

        using(var package = new ExcelPackage(new FileInfo(caminhoArquivo)))
        {
            var primeiraPlanilha = package.Workbook.Worksheets[0];

            int totalLinha = primeiraPlanilha.Dimension.Rows;
            int totalColunas = primeiraPlanilha.Dimension.Columns;

            for (int coluna = 1; coluna <= totalColunas; coluna++)
            {
                Console.Write(primeiraPlanilha.Cells[1, coluna].Value.ToString() + "\t");
            }
            Console.WriteLine();

            for (int linha = 2; linha <= totalLinha; linha++)
            {
                for (int coluna = 1; coluna <= totalColunas; coluna++)
                {
                    Console.Write(primeiraPlanilha.Cells[linha, coluna].Value.ToString() + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}