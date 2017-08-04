### Possible Issues

#### Running ./build.sh Fails On Restore

If you have a 2.0.0-* version of the dotnet SDK installed, restore will fail with the following error
after performing the first time package cache setup:

```
Failed to create prime the NuGet cache. new failed with: 5
```

The [current workaround](https://github.com/dotnet/cli/issues/6550#issuecomment-308040963) is to set `DOTNET_SKIP_FIRST_TIME_EXPERIENCE`:

```
export DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
```

## Development

### Creating Functions

1. Define the primary service (see `FooService`) that implements `IExecutable<out TOut, in TIn>`
2. Define a class (see `FooServiceEntry`) that inherits `EntryPoint<TService, TIn, TOut>`

### Additional Dependencies

If you need dependencies, such as an FtpReader or FtpWriter, injected into your function service, you need to:

1. Define the dependencies in the `Core` project
2. Define which implementations get resolved for which environment:
   - Register the local implementation in `ServerlessHost.Modules.LocalModule` 
   - Register the lambda implementation in `ServerlessHost.Modules.LambdaModule` 