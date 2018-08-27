using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Domain.Entities
{
    public class Cliente
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual string cpfCnpj { get; set; }
        public virtual DateTime dataCadastro { get; set; }
        public virtual IList<Produto> produtos { get; set; }

        public Cliente()
        {
            produtos = new List<Produto>();
        }

    }
}
