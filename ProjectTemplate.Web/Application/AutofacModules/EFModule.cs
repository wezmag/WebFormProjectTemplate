using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using ProjectTemplate.Data;
using ProjectTemplate.Core.Interface;

namespace ProjectTemplate.Web.Application.AutofacModules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(DataContext)).As(typeof(IDataContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
            base.Load(builder);
        }
    }
}