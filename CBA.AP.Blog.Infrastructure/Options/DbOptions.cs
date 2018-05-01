using Microsoft.Extensions.Options;

namespace CBA.AP.Blog.Infrastructure.Options
{
    public class DbOptions : IOptions<DbOptions>
    {
        public string ConnectionString { get; set; }

        public DbOptions Value => this;
    }
}