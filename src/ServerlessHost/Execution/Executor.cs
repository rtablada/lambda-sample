using Autofac;

public interface IExecutable<in TIn>
{
    void Execute(TIn input);
}

public interface IExecutable<in TIn, out TOut>
{
    TOut Execute(TIn input);
}

public class EntryPoint<TService, TIn>
    where TService : IExecutable<TIn>
{
    public void Run(TIn request)
    {
        using (var scope = ServiceProvider<TService>.Container.BeginLifetimeScope())
            scope.Resolve<TService>().Execute(request);
    }
}

public class EntryPoint<TService, TIn, TOut>
    where TService : IExecutable<TIn, TOut>
{
    public TOut Run(TIn request)
    {
        using (var scope = ServiceProvider<TService>.Container.BeginLifetimeScope())
            return scope.Resolve<TService>().Execute(request);
    }
}