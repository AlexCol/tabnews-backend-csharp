using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tabnews_backend_csharp.src.configs.database;
using tabnews_backend_csharp.src.configs.routes;

namespace tabnews_backend_csharp.src.configs.toBuilder;

public static class DependenciesBuilder {
    public static void AddDependencies(this WebApplicationBuilder builder) {
        //!adicionando configurações padrão .Net
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddControllers();
        /*
        builder.Services //! descartado, mas fica como exemplo, para uso de rotas dinamicas (estilo next), considerando a namespace
            .AddControllers(options => { options.Conventions.Add(new ControllersConvention()); })
            .ConfigureApplicationPartManager(apm => { apm.FeatureProviders.Add(new ControllersProvider()); });
        */

        //!adicionando configurações via extensão
        builder.AddLogConfig();
        builder.AddCorsConfig();


        //!adicionando classes para injeções de dependencia
        builder.Services.AddScoped<IConnectionFactory, ConnectionFactory>();
    }
}
