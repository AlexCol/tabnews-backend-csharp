using Dapper;
using Microsoft.AspNetCore.Mvc;
using tabnews_backend_csharp.src.configs.database;

namespace tabnews_backend_csharp.src.controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class StatusController : ControllerBase {
    private readonly IConnectionFactory _connectionFactory;
    private readonly IConfiguration _configuration;

    public StatusController(IConfiguration configuration, IConnectionFactory connectionFactory) {
        _configuration = configuration;
        _connectionFactory = connectionFactory;
    }

    [HttpGet]
    public async Task<IActionResult> GetStatusAsync() {
        string sql;
        var updatedAt = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

        sql = "SELECT version()";
        var version = await _connectionFactory.QueryFirstOrDefaultAsync<string>(sql);
        version = version.Split(' ')[1];

        sql = "select current_setting('max_connections')::int";
        var maxConnections = await _connectionFactory.QueryFirstOrDefaultAsync<int>(sql);

        sql = $"SELECT count(*)::int FROM pg_stat_activity WHERE datname = :databaseName";
        var databaseName = _configuration.GetConnectionString("DefaultConnection").Split(';').FirstOrDefault(x => x.StartsWith("Database="))?.Split('=')[1];
        var currentConnections = await _connectionFactory.QueryFirstOrDefaultAsync<int>(sql, new { databaseName });

        var retorno = new {
            updatedAt,
            dependencies = new {
                database = new {
                    version,
                    maxConnections,
                    currentConnections
                }
            },
        };

        return Ok(retorno);
    }
}
