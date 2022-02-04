using Autofac;
using M2HW4;
using M2HW4.DI;
public class Program
{
    public static void Main()
    {
        DependencyInjector dependencyInjector = new DependencyInjector();
        var container = dependencyInjector.DependencyInicialization();
        var starter = container.Resolve<Starter>();
        starter.Run();
    }
}