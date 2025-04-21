using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabnews_backend_csharp.src.configs.toApp;

public static class CorsDependencyBuilder {
    public static void AddCorsConfig(this WebApplication app) {
        app.UseCors("FromFrontEnd"); //! usar cors policy
    }
}
