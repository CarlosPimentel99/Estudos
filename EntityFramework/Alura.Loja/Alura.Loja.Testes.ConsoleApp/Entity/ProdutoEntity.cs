using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class ProdutoEntity : IProdutoEntity, IDisposable
    {
        private LojaContext _contexto;

        public ProdutoEntity(LojaContext contexto)
        {
            _contexto = contexto;
        }

        public void AdicionarProduto(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }

        public void AtualizarProduto(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
        }

        public IList<Produto> BuscarProdutos()
        {
            return _contexto.Produtos.ToList();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public void RemoverProduto(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
        }
    }
}