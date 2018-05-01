using System.Collections.Generic;
using System.Threading.Tasks;
using CBA.AP.Blog.Domain.Models;
using CBA.AP.Blog.Domain.Repositories;
using CBA.AP.Blog.Services.Interfaces;

namespace CBA.AP.Blog.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public async Task<IEnumerable<Post>> GetAsync()
        {
            return await this.blogRepository.GetAsync();
        }
    }
}