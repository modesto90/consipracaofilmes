using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Application.Models
{
    public class ClienteModel
    {
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]

        public string cpfCnpj { get; set; }
        public DateTime dataCadastro { get; set; }
        public List<ProdutoModel> produtos { get; set; }
        public ClienteModel()
        {
            this.dataCadastro = DateTime.Now;
        }
    }
}
