using Microsoft.EntityFrameworkCore;
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

        public List<Blog> GetBlogByCategoryList()
        {
            using var context = new BlogContext();
            var value = context.Blogs.Include(x => x.Category).Where(x => x.IsFeatured == true).ToList();
            return value;
        }

        public List<Blog> GetBlogByCommentList()
        {
            using var context = new BlogContext();
            var value = context.Blogs.Include(x => x.Category).Include(s => s.Comments).Where(x => x.Comments.Count > 3).Take(4).ToList();
            return value;
        }

        public List<Blog> GetCategoryByBlogList(int id)
        {
            using var context = new BlogContext();
            var value = context.Blogs.Include(x => x.Category).Where(x => x.CategoryID == id).ToList();
            return value;
        }

        public List<Blog> GetCategoryByFeaturedList()
        {
            using var context = new BlogContext();
            var value = context.Blogs.Include(x => x.Category).Where(p => p.IsFeatured == true).ToList();
            return value;
        }

        public List<Blog> GetLastBlogByList()
        {
            using var context = new BlogContext();
            var value = context.Blogs.Include(x => x.Category).OrderByDescending(x => x.BlogID).Take(8).ToList();
            return value;
        }

        public List<Blog> GetLastBlogByPopupTwoList()
        {
            using var context = new BlogContext();
            var value = context.Blogs.Include(x => x.Category).OrderByDescending(x => x.BlogID).Take(2).ToList();
            return value;
        }

        public List<Blog> GetMostPopularBlogList()
        {
            using var context = new BlogContext();
            var value = context.Blogs.Include(x => x.Category).Where(p => p.TopViewCount > 20).ToList();
            return value;
        }

        public int TotalViewCount(int id)
        {
            var context = new BlogContext();
            var value = context.Blogs.FirstOrDefault(x => x.BlogID == id);
            if (value != null)
            {
                if (value.TopViewCount == null)
                    value.TopViewCount = 0;

                value.TopViewCount++;
                context.SaveChanges();
            }
            return context.Blogs.Where(x => x.BlogID == id).Count();
        }
    }
}
