using System;
using System.IO;
using Autofac;
using Microsoft.Extensions.Configuration;

public class EnvironmentModule : Module
{
    private const string ENV_CONFIG_KEY = "N2_ENVIRONMENT";
    private const ExecutionEnvironment DEFUALT_ENVIRONMENT = ExecutionEnvironment.Local;
    protected readonly IConfiguration Config;

    public EnvironmentModule()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables();

        Config = builder.Build();
    }

    protected override void Load(ContainerBuilder builder)
    {
        var env = GetEnvironment();
        Console.WriteLine($"Starting in environment: {env}");
        switch(env)
        {
            case ExecutionEnvironment.Local:
            case ExecutionEnvironment.Test:
                builder.RegisterModule<LocalModule>();
                break;
            case ExecutionEnvironment.Lambda:
                builder.RegisterModule<LambdaModule>();
                break;
            default:
                throw new InvalidOperationException($"Unexpected environment '{env}'");
        }
    }

    private ExecutionEnvironment GetEnvironment()
    {
        if(Enum.TryParse(Config[ENV_CONFIG_KEY], out ExecutionEnvironment result))
            return result;

        return DEFUALT_ENVIRONMENT;
    }
}