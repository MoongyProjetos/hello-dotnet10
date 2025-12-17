var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.EFCore10Exemplo_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.EFCore10Exemplo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
