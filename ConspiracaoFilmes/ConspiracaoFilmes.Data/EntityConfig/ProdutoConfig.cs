using ConspiracaoFilmes.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Data.EntityConfig
{
    public class ProdutoConfig : ClassMap<Produto>
    {
        public ProdutoConfig()
        {
            Table("Produto");
            Id(p => p.id).GeneratedBy.Identity();
            Map(p => p.peso);
            Map(p => p.tipoPeso).Not.Nullable();
            Map(p => p.nome).Length(100).Not.Nullable();
            Map(p => p.quantidade).Not.Nullable();
            Map(p => p.valor).Not.Nullable();
            References(p => p.cliente)
  .Column("ClienteId").LazyLoad();
        }
    }
}
