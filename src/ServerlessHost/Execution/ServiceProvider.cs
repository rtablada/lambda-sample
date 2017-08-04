using System;
using Autofac;

public sealed class ServiceProvider<TService>
{
    private static readonly Lazy<IContainer> lazy = new Lazy<IContainer>(() => Build());
    public static IContainer Container => lazy.Value;

    private static IContainer Build()
    {
        var builder = new ContainerBuilder();

        builder.RegisterModule<EnvironmentModule>();

        builder.RegisterType<TService>();

        var container = builder.Build();

        return container;
    }
}