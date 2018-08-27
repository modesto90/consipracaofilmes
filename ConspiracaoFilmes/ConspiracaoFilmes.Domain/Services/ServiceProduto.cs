using ConspiracaoFilmes.Domain.Entities;
using ConspiracaoFilmes.Domain.Interfaces.Repositories;
using ConspiracaoFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Domain.Services
{
    public class ServiceProduto: ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositorioProduto _repositorio;

        public ServiceProduto(IRepositorioProduto repositorio)
            :base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
