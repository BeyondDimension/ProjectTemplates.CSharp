namespace Company.ProjectName.Services.Implementation;

sealed class IInterface1ServiceImpl : IInterface1Service
{
    readonly ILogger logger;

    public IInterface1ServiceImpl(ILogger<IInterface1ServiceImpl> logger)
    {
        this.logger = logger;
    }
}
