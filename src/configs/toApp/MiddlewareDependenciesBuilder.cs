using tabnews_backend_csharp.src.middlewares;

namespace tabnews_backend_csharp.src.configs.toApp;

public static class MiddlewareDependenciesBuilder {
    public static void AddMiddlewares(this WebApplication app) {
        //!adicionando middlewares, importante pois a ordem em que forem declarados, serão executados
        app.UseMiddleware<ExceptionHandlingMiddleware>();
        app.UseMiddleware<LogMiddleware>();
    }
}
