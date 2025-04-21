using Serilog;
using Serilog.Events;

namespace tabnews_backend_csharp.src.configs.toBuilder;

public static class LogDependencyBuilder {
    public static void AddLogConfig(this WebApplicationBuilder builder) {
        //!ativando serilog
        builder.Host.UseSerilog((context, configuration) => {
            configuration.MinimumLevel.Information();
            configuration.MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning);
            configuration.MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Error);
            configuration.Enrich.FromLogContext();
            configuration.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} - {SourceContext}{NewLine}{Exception}"); //SourceContext diz quem gerou
        });
    }
}
