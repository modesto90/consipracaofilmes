using ConspiracaoFilmes.Application.Models;
using ConspiracaoFilmes.Domain.Entities;


namespace ConspiracaoFilmes.Application.Interface
{
    public interface IAppServiceCliente : IAppServiceBase<Cliente>
    {
        void EditarCliente(ClienteModel model);

    }
}
