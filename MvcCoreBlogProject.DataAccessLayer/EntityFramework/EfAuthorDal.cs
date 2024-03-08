using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Concrete;
using MvcCoreBlogProject.DataAccessLayer.Repositories;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.EntityFramework
{
    public class EfAuthorDal : GenericRepository<Author>, IAuthorDal
    {
        public EfAuthorDal(BlogContext context) : base(context)
        {
        }

        public int GetAuthorByBlogCount(int id)
        {
            using var context = new BlogContext();
            var value = context.Blogs.Where(x => x.AuthorID == id).Count();
            return value;
        }
    }
}
