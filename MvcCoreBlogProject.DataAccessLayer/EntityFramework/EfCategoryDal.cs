using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Concrete;
using MvcCoreBlogProject.DataAccessLayer.Repositories;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(BlogContext context) : base(context)
        {
        }

        //Kategorilerde IsStatus=true olanların toplam adedini getirme
        public int CategoryByCount()
        {
            using var context = new BlogContext();
            return context.Categories.Where(x => x.IsStatus == true).Count();
        }
    }
}
