using Alura.Loja.Testes.ConsoleApp.Classes.Promocao;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Runtime.Remoting;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var cliente = contexto.Clientes.Include(e => e.EnderecoDeEntrega).FirstOrDefault();
                Console.WriteLine($"Endereço de entrega: {cliente.EnderecoDeEntrega.Logradouro}");


                var produto = contexto.Produtos.Include(p => p.Compras).Where(p => p.Id == 15).FirstOrDefault();


                contexto.Entry(produto).Collection(p => p.Compras).Query().Where(c => c.Preco > 10).Load();

                Console.WriteLine($"\nMostrando as Compras do Produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void ExibeProdutosDaPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                var promocao = contexto2.Promocoes.Include(p => p.Produtos).ThenInclude(pp => pp.Produto).FirstOrDefault();
                Console.WriteLine("\nMostrando os produtos da promoção");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total de Janeiro 2024";
                promocao.DataInicio = new DateTime(2024, 1, 1);
                promocao.DataTermino = new DateTime(2024, 1, 31);

                var produtos = contexto.Produtos.Where(p => p.Categoria == "Bebidas").ToList();

                foreach (var produto in produtos)
                {
                    promocao.IncluiProduto(produto);
                }

                contexto.Promocoes.Add(promocao);
                contexto.SaveChanges();
            }
        }

        private static void ExemploDeMontagemDeTabelaComUmParaUm()
        {
            var cliente = new Cliente();
            cliente.Nome = "Falaninho de tal";
            cliente.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua dos Inválidos",
                Complemento = "Sobrado",
                Bairro = "Centro",
                Cidade = "Fernandópolis"
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
            }
        }

        private static void ExemploDeMontagemDeTabelaDeUmParaMuitos()
        {
            var p1 = new Produto()
            {
                Nome = "Suco de Laranja",
                Categoria = "Bebidas",
                PrecoUnitario = 8.79,
                Unidade = "Litros"
            };
            var p2 = new Produto()
            {
                Nome = "Café",
                Categoria = "Bebidas",
                PrecoUnitario = 12.45,
                Unidade = "Gramas"
            };
            var p3 = new Produto()
            {
                Nome = "Macarrão",
                Categoria = "Alimentos",
                PrecoUnitario = 4.25,
                Unidade = "Gramas"
            };


            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                contexto.Promocoes.Add(promocaoDePascoa);
                contexto.SaveChanges();
            }
        }
    }
}
