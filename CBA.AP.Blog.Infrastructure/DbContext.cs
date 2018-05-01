using System.Data;
using CBA.AP.Blog.Infrastructure.Options;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace CBA.AP.Blog.Infrastructure
{
    public class DbContext
    {
        private readonly DbOptions dbOptions;

        public DbContext(IOptions<DbOptions> dbOptions)
        {
            this.dbOptions = dbOptions.Value;
        }

        public IDbConnection GetConnection()
        {
            return new MySqlConnection(this.dbOptions.ConnectionString);
        }
    }
}