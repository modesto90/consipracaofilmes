using ConspiracaoFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Application.Models
{
    public class GridModel
    {
        public int idProduto { get; set; }
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }
        public string nomeProduto { get; set; }
        public int quantidade { get; set; }
        public string peso { get; set; }

        public GridModel(Produto p)
        {
            idCliente = p.cliente.id;
            idProduto = p.id;
            nomeCliente = p.cliente.nome;
            nomeProduto = p.nome;
            quantidade = p.quantidade;
            peso = p.peso.HasValue ? p.peso.ToString() : "Não possui";
        }
    }
}
