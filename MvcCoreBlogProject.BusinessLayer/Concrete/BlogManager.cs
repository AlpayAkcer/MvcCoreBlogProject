using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TAdd(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public void TDelete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public List<Blog> TGetBlogByCategoryList()
        {
            return _blogDal.GetBlogByCategoryList();
        }

        public List<Blog> TGetBlogByCommentList()
        {
            return _blogDal.GetBlogByCommentList();
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetByID(id);
        }

        public List<Blog> TGetCategoryByBlogList(int id)
        {
            return _blogDal.GetCategoryByBlogList(id);
        }

        public List<Blog> TGetCategoryByFeaturedList()
        {
            return _blogDal.GetCategoryByFeaturedList();
        }

        public List<Blog> TGetListAll()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> TGetMostPopularBlogList()
        {
            return _blogDal.GetMostPopularBlogList();
        }

        public int TTotalViewCount(int id)
        {
            return _blogDal.TotalViewCount(id);
        }

        public void TUpdate(Blog entity)
        {
            _blogDal.Update(entity);
        }
    }
}
