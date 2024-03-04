using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Concrete;
using MvcCoreBlogProject.DataAccessLayer.Repositories;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public EfBlogDal(BlogContext context) : base(context)
        {
        }
    }
}
