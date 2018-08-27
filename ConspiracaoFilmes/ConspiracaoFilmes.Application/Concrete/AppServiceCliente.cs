using ConspiracaoFilmes.Application.Interface;
using ConspiracaoFilmes.Application.Models;
using ConspiracaoFilmes.Domain.Entities;
using ConspiracaoFilmes.Domain.Interfaces.Services;
using FluentNHibernate.Automapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Application.Concrete
{
    public class AppServiceCliente : AppServiceBase<Cliente>, IAppServiceCliente
    {
        private readonly IServiceCliente _service;

        public AppServiceCliente(IServiceCliente service)
            :base(service)
        {
            _service = service;
        }

        public void EditarCliente(ClienteModel model)
        {
            Cliente c =_service.GetById(model.id);
            //se fosse para editar todos os dados eu poderia simplesmente usar o automapper para tratar os dados

            //c = AutoMapper.Mapper.Map<ClienteModel, Cliente>(model);
            c.nome = model.nome;
            _service.Att(c);


        }
    }
}
