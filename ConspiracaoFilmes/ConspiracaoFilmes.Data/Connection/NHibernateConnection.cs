using ConspiracaoFilmes.Data.EntityConfig;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConspiracaoFilmes.Data.Connection
{
    public class NHibernateConnection : IDisposable
    {
        public static ISessionFactory sessionFactory;
        public ITransaction transaction;
        public ISession session;
        public NHibernateConnection()
        {
            sessionFactory = CriarSessao();
            session = AbrirSessao();
            transaction = session.BeginTransaction();
        }
        private static ISessionFactory CriarSessao()
        {
            if (sessionFactory != null)
                return sessionFactory;

            //configurar a conexao
            FluentConfiguration configuration = Fluently.Configure()
                .Database(
                 MySQLConfiguration.Standard
                 .ConnectionString(x => x.Server("localhost")
                 .Username("root").Password("1234")
                 .Database("conspiracaofilmesdb")))
                 .Mappings(c => c.FluentMappings.AddFromAssemblyOf<ClienteConfig>());
                 //.ExposeConfiguration(cfg =>
                 //new SchemaExport(cfg)
                 //.Create(false, true));

            sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory = configuration.BuildSessionFactory();
            ;

        }

        public static ISession AbrirSessao()
        {
            return CriarSessao().OpenSession();
        }

        public void Dispose()
        {
            if(sessionFactory != null)
            {
                sessionFactory.Dispose();
            }

        }
    }
}
