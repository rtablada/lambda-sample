using Autofac;

public class LambdaModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<LambdaRequestWriter>()
            .As<IRequestWriter>();

        builder.RegisterType<FtpWriter>()
            .As<IFtpWriter>();
    }
}