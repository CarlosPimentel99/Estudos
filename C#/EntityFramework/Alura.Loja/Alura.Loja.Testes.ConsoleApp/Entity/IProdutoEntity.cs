using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public interface IProdutoEntity
    {
        void AdicionarProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        IList<Produto> BuscarProdutos();
        void RemoverProduto(Produto produto);
    }
}