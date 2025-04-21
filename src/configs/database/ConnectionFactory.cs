using System.Data;
using Dapper;

namespace tabnews_backend_csharp.src.configs.database;

public class ConnectionFactory : IConnectionFactory {
    protected readonly IConfiguration _configuration;
    public IDbConnection Connection { get; private set; }

    public ConnectionFactory(IConfiguration configuration) {
        _configuration = configuration;
    }

    public void Dispose() {
        Connection.Close();
        Connection.Dispose();
        Connection = null;
    }

    private void Connect() {
        if (Connection is null || Connection.State == ConnectionState.Closed) {
            Connection = new Npgsql.NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            Connection.Open();
        }
    }

    public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null) {
        using var conn = GetConnection();
        return await conn.QueryFirstOrDefaultAsync<T>(sql, param);
    }

    private IDbConnection GetConnection() {
        Connect();
        return Connection;
    }
}
