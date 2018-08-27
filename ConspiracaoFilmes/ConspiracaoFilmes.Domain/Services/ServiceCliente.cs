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
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositorioCliente _repositorio;

        public ServiceCliente(IRepositorioCliente repositorio)
            :base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
