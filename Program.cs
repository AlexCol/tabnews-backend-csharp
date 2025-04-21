using tabnews_backend_csharp.src.configs.toApp;
using tabnews_backend_csharp.src.configs.toBuilder;

var builder = WebApplication.CreateBuilder(args);
builder.AddDependencies();

var app = builder.Build();
app.AddDependencies();
app.Run();
