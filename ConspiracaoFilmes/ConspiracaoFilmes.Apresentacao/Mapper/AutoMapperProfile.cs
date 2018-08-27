using AutoMapper;
using ConspiracaoFilmes.Application.Models;
using ConspiracaoFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConspiracaoFilmes.Apresentacao.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClienteModel, Cliente>();
            CreateMap<Cliente, ClienteModel>();
            CreateMap<ProdutoModel, Produto>();
            CreateMap<Produto, ProdutoModel>();
        }
    }
}