using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        int TCategoryByCount();
    }
}
