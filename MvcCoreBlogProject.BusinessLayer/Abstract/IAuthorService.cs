using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.Abstract
{
    public interface IAuthorService : IGenericService<Author>
    {
        int TGetAuthorByBlogCount(int id);
    }
}
