using ConspiracaoFilmes.Domain.Interfaces.Repositories;
using ConspiracaoFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositorioBase<T> _repositorio;

        public ServiceBase(IRepositorioBase<T> repositorio)
        {
            _repositorio = repositorio;
        }
        public void Add(T obj)
        {
            _repositorio.Add(obj);
        }

        public void Att(T obj)
        {
            _repositorio.Att(obj);
        }


        public void dispose()
        {
            _repositorio.dispose();
        }

        public IEnumerable<T> GetAll()
        {
            return _repositorio.GetAll();
        }

        public T GetById(int id)
        {
            return _repositorio.GetById(id);
        }

        public void remove(T obj)
        {
            _repositorio.remove(obj);
        }
    }
}
