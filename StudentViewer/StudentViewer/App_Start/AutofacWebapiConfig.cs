using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Repository;
using Repository.Common;

namespace StudentViewer.App_Start
{

    [SecurityCritical]
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<StudentDBEntities>()
                   .As<DbContext>().InstancePerApiRequest();
                   
            builder.RegisterType<DbFactory>()
                   .As<IDbFactory>()
                   .InstancePerApiRequest();

            builder.RegisterGeneric(typeof(GenericRepository<>))
                   .As(typeof(IGenericRepository<>))
                   .InstancePerApiRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }  
    }
}