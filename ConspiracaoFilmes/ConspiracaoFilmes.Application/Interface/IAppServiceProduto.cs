using ConspiracaoFilmes.Application.Models;
using ConspiracaoFilmes.Domain.Entities;
using System.Collections.Generic;

namespace ConspiracaoFilmes.Application.Interface
{
    public interface IAppServiceProduto : IAppServiceBase<Produto>
    {
        void AdicionarProduto(ProdutoModel model);
        List<GridModel> GetProdutos();
        void AtualizarProduto(ProdutoModel model);
    }
}
