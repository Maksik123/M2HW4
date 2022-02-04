using Autofac;
using M2HW4;
using M2HW4.DI;
public class Program
{
    public static void Main()
    {
        AutoFac autoFac = new AutoFac();
        autoFac.Application_Start();
    }
}