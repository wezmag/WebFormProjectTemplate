using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Integration.Web;
using Autofac;
using ProjectTemplate.Web.Application.AutofacModules;

namespace ProjectTemplate.Web.Application
{
    public class AutofacHelper
    {
        public static IContainer Bootstrapper()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new EFModule());
            var container = builder.Build();
            return container;
        }
    }
}