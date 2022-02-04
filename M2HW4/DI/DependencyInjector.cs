using Autofac;
using M2HW4.Interfaces;
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
            return builder.Build();
        }
    }
}
