

using System.Collections.Generic;

namespace ConspiracaoFilmes.Application.Interface
{
    public interface IAppServiceBase<T>  where T: class
    {
        void Add(T obj);
        void Att(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void remove(T obj);
    }
}
