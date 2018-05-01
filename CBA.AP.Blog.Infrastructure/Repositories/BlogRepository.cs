using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBA.AP.Blog.Domain.Models;
using CBA.AP.Blog.Domain.Repositories;
using Dapper;

namespace CBA.AP.Blog.Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly DbContext dbContext;
        
        public BlogRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Post>> GetAsync()
        {
            const string query = "SELECT id, title, content " +
                                 // kane join me comments table gia na pareis kai ta comments
                                 "FROM posts";
            
            using (var connection = this.dbContext.GetConnection())
            {
                return await connection.QueryAsync<Post>(query);
            }
        }
    }
}