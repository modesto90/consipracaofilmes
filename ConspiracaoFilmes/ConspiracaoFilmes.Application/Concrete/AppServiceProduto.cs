using ConspiracaoFilmes.Application.Interface;
using ConspiracaoFilmes.Application.Models;
using ConspiracaoFilmes.Domain.Entities;
using ConspiracaoFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Application.Concrete
{
    public class AppServiceProduto : AppServiceBase<Produto>, IAppServiceProduto
    {
        private readonly IServiceProduto _service;
        private readonly IServiceCliente _serviceCliente;

        public AppServiceProduto(IServiceProduto service,
            IServiceCliente serviceCliente)
            :base(service)
        {
            _serviceCliente = serviceCliente;
            _service = service;
        }

        public void AtualizarProduto(ProdutoModel model)
        {
            Produto p = _service.GetById(model.id);
            p.nome = model.nome;
            p.peso = model.peso;
            p.quantidade = model.quantidade;
            p.valor = model.valor;
            p.tipoPeso = model.tipoPeso;
            _service.Att(p);
        }

        public List<GridModel> GetProdutos()
        {
            List<GridModel> retorno = new List<GridModel>();
            List<Produto> produtos =  _service.GetAll().ToList();

            foreach (var item in produtos)
                retorno.Add(new GridModel(item));
            
            return retorno;
        }

        public void AdicionarProduto(ProdutoModel model)
        {
            Produto p = AutoMapper.Mapper.Map<ProdutoModel, Produto>(model);
            Cliente c = _serviceCliente.GetById(model.idCliente);
            c.produtos.Add(p);
            p.cliente = c;
            _service.Add(p);

        }
    }
}
