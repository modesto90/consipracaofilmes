using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T obj);
        void Att(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void remove(T obj);
        void dispose();
    }
}
