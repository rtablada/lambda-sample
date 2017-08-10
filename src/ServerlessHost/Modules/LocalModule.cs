using Autofac;

public class LocalModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<LocalRequestWriter>()
            .As<IRequestWriter>()
            .SingleInstance();

        builder.RegisterType<FileSystemWriter>()
            .As<IFtpWriter>();
    }
}
