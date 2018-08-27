using ConspiracaoFilmes.Application.Interface;
using ConspiracaoFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Application.Concrete
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {
        private readonly IServiceBase<T> _service;

        public AppServiceBase(IServiceBase<T> service)
        {
            _service = service;
        }
        public void Add(T obj)
        {
            _service.Add(obj);
        }

        public void Att(T obj)
        {
            _service.Att(obj);
        }

       
    
        public IEnumerable<T> GetAll()
        {
            return _service.GetAll();
        }

        public T GetById(int id)
        {
            return _service.GetById(id);
        }

        public void remove(T obj)
        {
            _service.remove(obj);
        }
    }
}
