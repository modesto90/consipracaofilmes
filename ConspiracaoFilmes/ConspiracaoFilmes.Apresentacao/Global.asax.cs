using ConspiracaoFilmes.Application.Concrete;
using ConspiracaoFilmes.Application.Interface;
using ConspiracaoFilmes.Apresentacao.Mapper;
using ConspiracaoFilmes.Data.Repositories;
using ConspiracaoFilmes.Domain.Interfaces.Repositories;
using ConspiracaoFilmes.Domain.Interfaces.Services;
using ConspiracaoFilmes.Domain.Services;
using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ConspiracaoFilmes.Apresentacao
{
    public class MvcApplication : NinjectHttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                });
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IAppServiceCliente>().To<AppServiceCliente>();
            kernel.Bind<IAppServiceProduto>().To<AppServiceProduto>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IServiceCliente>().To<ServiceCliente>();
            kernel.Bind<IServiceProduto>().To<ServiceProduto>();


            kernel.Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
            kernel.Bind<IRepositorioCliente>().To<RepositorioCliente>();
            kernel.Bind<IRepositorioProduto>().To<RepositorioProduto>();

            // e.g. kernel.Load(Assembly.GetExecutingAssembly());
        }

        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
        //protected void Application_Start()
        //{
        //    AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
        //    AreaRegistration.RegisterAllAreas();
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    BundleConfig.RegisterBundles(BundleTable.Bundles);
        //}
    }
}
