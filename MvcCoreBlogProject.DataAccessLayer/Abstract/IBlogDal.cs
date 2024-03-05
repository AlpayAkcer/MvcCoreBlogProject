using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetBlogByCategoryList();
        List<Blog> GetCategoryByFeaturedList();
        List<Blog> GetBlogByCommentList();
        int TotalViewCount(int id);
        List<Blog> GetCategoryByBlogList(int id);
        List<Blog> GetMostPopularBlogList();
    }
}
