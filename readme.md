# Possible Issues

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

### Creating Functions

1. Define an entry service that implements `IExecutionService<out TOut, in TIn>`
2. Define a module that registers all required dependencies
3. Add a "pointer" method to MyServiceFcn
