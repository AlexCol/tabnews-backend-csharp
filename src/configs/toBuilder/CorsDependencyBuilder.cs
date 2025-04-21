using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabnews_backend_csharp.src.configs.toBuilder;

public static class CorsDependencyBuilder {
    public static void AddCorsConfig(this WebApplicationBuilder builder) {
        var origin = builder.Configuration["CorsOrigin"];
        builder.Services.AddCors(options => {
            options.AddPolicy("FromFrontEnd",
                policy => policy
                    .WithOrigins(origin) // Substitua pela origem específica do seu frontend
                    .SetIsOriginAllowedToAllowWildcardSubdomains() // Permite subdomínios (opcional) -- necessário se não informar a porta
                    .AllowCredentials()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });
    }
}
