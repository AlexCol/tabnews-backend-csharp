using System.Data;

namespace tabnews_backend_csharp.src.configs.database;

public interface IConnectionFactory {
    void Dispose();
    Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null);
    //IDbConnection GetConnection();
}
