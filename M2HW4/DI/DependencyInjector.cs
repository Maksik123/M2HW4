using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Interfaces;
using System.Web.Mvc;
using M2HW4.Services;

namespace M2HW4.DI
{
    public class DependencyInjector
    {
        public IContainer DependencyInicialization()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NotificationService>().As<IShowInfo>();
            builder.RegisterType<Starter>();
            var config = builder.Build();
            return config;
        }
    }
}
