using ConspiracaoFilmes.Domain.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Application.Models
{
    public class ProdutoModel
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual decimal valor { get; set; }
        public virtual int quantidade { get; set; }
        public virtual TipoPeso tipoPeso { get; set; }
        public virtual double? peso { get; set; }
        public int idCliente { get; set; }
    }
}
