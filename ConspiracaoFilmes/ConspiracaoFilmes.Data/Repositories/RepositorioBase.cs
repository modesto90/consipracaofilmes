using ConspiracaoFilmes.Data.Connection;
using ConspiracaoFilmes.Domain.Interfaces;
using ConspiracaoFilmes.Domain.Interfaces.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Data.Repositories
{
    public class RepositorioBase<T> : IRepositorioBase<T>, IDisposable where T : class
    {
        private NHibernateConnection _config;
        public RepositorioBase()
        {
            _config = new NHibernateConnection();
        }
        public void Add(T obj)
        {

            try
            {

                _config.session.Save(obj);
                _config.transaction.Commit();

            }
            catch (Exception ex)
            {
                if (!_config.transaction.WasCommitted)
                    _config.transaction.Rollback();

                throw new Exception("Erro ao salvar: " + ex.Message);

            }

        }

        public void Att(T obj)
        {

            try
            {
                _config.session.Update(obj);
                _config.transaction.Commit();
            }
            catch (Exception ex)
            {
                if (!_config.transaction.WasCommitted)
                    _config.transaction.Rollback();

                throw new Exception("Erro ao atualizar: " + ex.Message);

            }

        }

        public void dispose()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            var all = _config.session.QueryOver<T>().List();

            return all;

        }

        public T GetById(int id)
        {

            return _config.session.Get<T>(id);

        }

        public void remove(T obj)
        {

            try
            {

                _config.session.Delete(obj);
                _config.transaction.Commit();

            }
            catch (Exception ex)
            {
                if (!_config.transaction.WasCommitted)
                    _config.transaction.Rollback();

                throw new Exception("Erro ao salvar: " + ex.Message);

            }
        }
    }
}

