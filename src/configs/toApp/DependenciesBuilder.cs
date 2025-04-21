using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabnews_backend_csharp.src.configs.toApp;

public static class DependenciesBuilder {
    public static void AddDependencies(this WebApplication app) {
        //! adicionando configurações padrão .Net
        app.UseAuthorization();
        app.MapControllers();

        //! adicionando configurações via extensão
        app.AddMiddlewares();
        app.AddCorsConfig();

    }
}
