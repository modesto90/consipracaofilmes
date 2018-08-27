using ConspiracaoFilmes.Domain.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Domain.Commons.Helpers
{
    public class ServerStatus
    {
        public StatusMensagem status { get; set; }
        public string mensagem { get; set; }
    }
}
