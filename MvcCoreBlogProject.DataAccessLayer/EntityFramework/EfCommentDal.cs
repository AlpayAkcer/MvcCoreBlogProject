using Microsoft.EntityFrameworkCore;
using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Concrete;
using MvcCoreBlogProject.DataAccessLayer.Repositories;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(BlogContext context) : base(context)
        {
        }

        public List<Comment> GetCommentsByBlogList(int id)
        {
            using var context = new BlogContext();          
            var value = context.Comments.Include(x => x.Blog).Where(x => x.BlogID == id).ToList();
            return value;
        }
    }
}
