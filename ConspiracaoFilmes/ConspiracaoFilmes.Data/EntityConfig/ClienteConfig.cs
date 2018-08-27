using ConspiracaoFilmes.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Data.EntityConfig
{
    public class ClienteConfig : ClassMap<Cliente>
    {
        public ClienteConfig()
        {
            Table("Cliente");
            Id(c => c.id).GeneratedBy.Identity();
            Map(c => c.nome).Length(200).Not.Nullable();
            Map(c => c.cpfCnpj).Length(14).Not.Nullable();
            Map(c => c.dataCadastro).Not.Nullable();
            HasMany(c => c.produtos)
      .KeyColumn("ClienteId")
      .Inverse()
      .Cascade.AllDeleteOrphan().LazyLoad();
            //.LazyLoad();



        }
    }
}
