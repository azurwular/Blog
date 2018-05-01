using System.Collections.Generic;
using System.Threading.Tasks;
using CBA.AP.Blog.Domain.Models;

namespace CBA.AP.Blog.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<Post>> GetAsync();
    }
}