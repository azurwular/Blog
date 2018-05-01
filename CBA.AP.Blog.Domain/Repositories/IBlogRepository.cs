using System.Collections.Generic;
using System.Threading.Tasks;
using CBA.AP.Blog.Domain.Models;

namespace CBA.AP.Blog.Domain.Repositories
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Post>> GetAsync();
    }
}