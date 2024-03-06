using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> TGetBlogByCategoryList();
        List<Blog> TGetCategoryByFeaturedList();
        List<Blog> TGetBlogByCommentList();
        int TTotalViewCount(int id);
        List<Blog> TGetCategoryByBlogList(int id);
        List<Blog> TGetMostPopularBlogList();
        List<Blog> TGetLastBlogByList();
        List<Blog> TGetLastBlogByPopupTwoList();
    }
}
